﻿using BrawlLib.Wii.Audio;
using System;
using System.ComponentModel;

namespace BrawlLib.SSBB.ResourceNodes
{
    public unsafe class RSAREntryNode : ResourceNode
    {
        public override bool AllowDuplicateNames => false;

        [Browsable(false)]
        public RSARNode RSARNode
        {
            get
            {
                ResourceNode n = this;
                while ((n = n.Parent) != null && !(n is RSARNode))
                {
                    ;
                }

                return n as RSARNode;
            }
        }
#if DEBUG
        [Browsable(true)]
        [Category("DEBUG")]
#else
        [Browsable(false)]
#endif
        public virtual int StringId => 0;

        public int InfoIndex
        {
            get => _infoIndex;
            set
            {
                int i = 0;
                Type t = GetType();
                switch (t.Name)
                {
                    case "RSARSoundNode":
                        i = 0;
                        break;
                    case "RSARBankNode":
                        i = 1;
                        break;
                    case "RSARPlayerInfoNode":
                        i = 2;
                        break;
                    case "RSARGroupNode":
                        i = 4;
                        break;
                }

                System.Collections.Generic.List<RSAREntryNode> list = RSARNode._infoCache[i];
                int prevIndex = _infoIndex;
                _infoIndex = value.Clamp(0, list.Count - 1);
                if (_infoIndex == prevIndex)
                {
                    return;
                }

                RSAREntryNode temp = list[_infoIndex];
                temp._infoIndex = prevIndex;
                list[_infoIndex] = this;
                list[prevIndex] = temp;
            }
        }

        public int _infoIndex;
        internal VoidPtr Data => WorkingUncompressed.Address;

        [Category("Data")]
        [Browsable(true)]
        public string DataOffset
        {
            get
            {
                if (RSARNode != null)
                {
                    return ((uint) (Data - RSARNode.Header)).ToString("X");
                }
                else
                {
                    return null;
                }
            }
        }

        public VoidPtr _rebuildBase;
        public int _rebuildIndex, _rebuildStringId;

        public override bool OnInitialize()
        {
            if (_name == null)
            {
                RSARNode p = RSARNode;
                if (p != null)
                {
                    _name = p.Header->SYMBBlock->GetStringEntry(StringId);
                }
                else
                {
                    _name = string.Format("Entry{0}", StringId);
                }
            }

            return false;
        }

        internal string _fullPath;

        internal virtual void GetStrings(sbyte* path, int pathLen, RSAREntryList list)
        {
            int len = _name.Length;
            int i = 0;
            if (len == 0)
            {
                return;
            }

            len += pathLen + (pathLen != 0 ? 1 : 0);

            sbyte* chars = stackalloc sbyte[len];

            if (pathLen > 0)
            {
                while (i < pathLen)
                {
                    chars[i++] = *path++;
                }

                chars[i++] = (sbyte) '_';
            }

            fixed (char* s = _name)
            {
                for (int x = 0; i < len;)
                {
                    chars[i++] = (sbyte) s[x++];
                }
            }

            list.AddEntry(_fullPath = len != 0 ? new string(chars, 0, len) : "", this);
        }
    }
}