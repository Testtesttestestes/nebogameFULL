using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;

namespace I2.Loc.SimpleJSON
{
	// Token: 0x020013BC RID: 5052
	[Token(Token = "0x20013BC")]
	public class JSONArray : JSONNode, IEnumerable
	{
		// Token: 0x170017C8 RID: 6088
		[Token(Token = "0x170017C8")]
		public override JSONNode this[int aIndex]
		{
			[Token(Token = "0x600783F")]
			[Address(RVA = "0xC191", Offset = "0xC191", VA = "0xC191", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6007840")]
			[Address(RVA = "0xC192", Offset = "0xC192", VA = "0xC192", Slot = "6")]
			set
			{
			}
		}

		// Token: 0x170017C9 RID: 6089
		[Token(Token = "0x170017C9")]
		public override JSONNode this[string aKey]
		{
			[Token(Token = "0x6007841")]
			[Address(RVA = "0xC193", Offset = "0xC193", VA = "0xC193", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6007842")]
			[Address(RVA = "0xC194", Offset = "0xC194", VA = "0xC194", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x170017CA RID: 6090
		// (get) Token: 0x06007843 RID: 30787 RVA: 0x000161A0 File Offset: 0x000143A0
		[Token(Token = "0x170017CA")]
		public override int Count
		{
			[Token(Token = "0x6007843")]
			[Address(RVA = "0xC195", Offset = "0xC195", VA = "0xC195", Slot = "11")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06007844 RID: 30788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007844")]
		[Address(RVA = "0xC196", Offset = "0xC196", VA = "0xC196", Slot = "4")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		// Token: 0x06007845 RID: 30789 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007845")]
		[Address(RVA = "0xC197", Offset = "0xC197", VA = "0xC197", Slot = "14")]
		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		// Token: 0x06007846 RID: 30790 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007846")]
		[Address(RVA = "0xC198", Offset = "0xC198", VA = "0xC198", Slot = "15")]
		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		// Token: 0x170017CB RID: 6091
		// (get) Token: 0x06007847 RID: 30791 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170017CB")]
		public override IEnumerable<JSONNode> Childs
		{
			[Token(Token = "0x6007847")]
			[Address(RVA = "0xC199", Offset = "0xC199", VA = "0xC199", Slot = "16")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007848 RID: 30792 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007848")]
		[Address(RVA = "0xC19A", Offset = "0xC19A", VA = "0xC19A", Slot = "29")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06007849 RID: 30793 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007849")]
		[Address(RVA = "0xC19B", Offset = "0xC19B", VA = "0xC19B", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600784A RID: 30794 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600784A")]
		[Address(RVA = "0xC19C", Offset = "0xC19C", VA = "0xC19C", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}

		// Token: 0x0600784B RID: 30795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600784B")]
		[Address(RVA = "0xC19D", Offset = "0xC19D", VA = "0xC19D", Slot = "28")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}

		// Token: 0x0600784C RID: 30796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600784C")]
		[Address(RVA = "0xC19E", Offset = "0xC19E", VA = "0xC19E")]
		public JSONArray()
		{
		}

		// Token: 0x04003EF8 RID: 16120
		[Token(Token = "0x4003EF8")]
		[FieldOffset(Offset = "0x8")]
		private List<JSONNode> m_List;
	}
}
