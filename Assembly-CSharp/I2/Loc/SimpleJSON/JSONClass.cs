using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;

namespace I2.Loc.SimpleJSON
{
	// Token: 0x020013BF RID: 5055
	[Token(Token = "0x20013BF")]
	public class JSONClass : JSONNode, IEnumerable
	{
		// Token: 0x170017D0 RID: 6096
		[Token(Token = "0x170017D0")]
		public override JSONNode this[string aKey]
		{
			[Token(Token = "0x600785D")]
			[Address(RVA = "0xC1AF", Offset = "0xC1AF", VA = "0xC1AF", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x600785E")]
			[Address(RVA = "0xC1B0", Offset = "0xC1B0", VA = "0xC1B0", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x170017D1 RID: 6097
		[Token(Token = "0x170017D1")]
		public override JSONNode this[int aIndex]
		{
			[Token(Token = "0x600785F")]
			[Address(RVA = "0xC1B1", Offset = "0xC1B1", VA = "0xC1B1", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6007860")]
			[Address(RVA = "0xC1B2", Offset = "0xC1B2", VA = "0xC1B2", Slot = "6")]
			set
			{
			}
		}

		// Token: 0x170017D2 RID: 6098
		// (get) Token: 0x06007861 RID: 30817 RVA: 0x000161E8 File Offset: 0x000143E8
		[Token(Token = "0x170017D2")]
		public override int Count
		{
			[Token(Token = "0x6007861")]
			[Address(RVA = "0xC1B3", Offset = "0xC1B3", VA = "0xC1B3", Slot = "11")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06007862 RID: 30818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007862")]
		[Address(RVA = "0xC1B4", Offset = "0xC1B4", VA = "0xC1B4", Slot = "4")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		// Token: 0x06007863 RID: 30819 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007863")]
		[Address(RVA = "0xC1B5", Offset = "0xC1B5", VA = "0xC1B5", Slot = "13")]
		public override JSONNode Remove(string aKey)
		{
			return null;
		}

		// Token: 0x06007864 RID: 30820 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007864")]
		[Address(RVA = "0xC1B6", Offset = "0xC1B6", VA = "0xC1B6", Slot = "14")]
		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		// Token: 0x06007865 RID: 30821 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007865")]
		[Address(RVA = "0xC1B7", Offset = "0xC1B7", VA = "0xC1B7", Slot = "15")]
		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		// Token: 0x170017D3 RID: 6099
		// (get) Token: 0x06007866 RID: 30822 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170017D3")]
		public override IEnumerable<JSONNode> Childs
		{
			[Token(Token = "0x6007866")]
			[Address(RVA = "0xC1B8", Offset = "0xC1B8", VA = "0xC1B8", Slot = "16")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007867 RID: 30823 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007867")]
		[Address(RVA = "0xC1B9", Offset = "0xC1B9", VA = "0xC1B9", Slot = "29")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06007868 RID: 30824 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007868")]
		[Address(RVA = "0xC1BA", Offset = "0xC1BA", VA = "0xC1BA", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007869 RID: 30825 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007869")]
		[Address(RVA = "0xC1BB", Offset = "0xC1BB", VA = "0xC1BB", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}

		// Token: 0x0600786A RID: 30826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600786A")]
		[Address(RVA = "0xC1BC", Offset = "0xC1BC", VA = "0xC1BC", Slot = "28")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}

		// Token: 0x0600786B RID: 30827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600786B")]
		[Address(RVA = "0xC1BD", Offset = "0xC1BD", VA = "0xC1BD")]
		public JSONClass()
		{
		}

		// Token: 0x04003F02 RID: 16130
		[Token(Token = "0x4003F02")]
		[FieldOffset(Offset = "0x8")]
		private Dictionary<string, JSONNode> m_Dict;
	}
}
