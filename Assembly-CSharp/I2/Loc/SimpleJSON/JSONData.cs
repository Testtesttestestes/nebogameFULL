using System;
using System.IO;
using Il2CppDummyDll;

namespace I2.Loc.SimpleJSON
{
	// Token: 0x020013C3 RID: 5059
	[Token(Token = "0x20013C3")]
	public class JSONData : JSONNode
	{
		// Token: 0x170017D8 RID: 6104
		// (get) Token: 0x0600787E RID: 30846 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600787F RID: 30847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170017D8")]
		public override string Value
		{
			[Token(Token = "0x600787E")]
			[Address(RVA = "0xC1D0", Offset = "0xC1D0", VA = "0xC1D0", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x600787F")]
			[Address(RVA = "0xC1D1", Offset = "0xC1D1", VA = "0xC1D1", Slot = "10")]
			set
			{
			}
		}

		// Token: 0x06007880 RID: 30848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007880")]
		[Address(RVA = "0xC1D2", Offset = "0xC1D2", VA = "0xC1D2")]
		public JSONData(string aData)
		{
		}

		// Token: 0x06007881 RID: 30849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007881")]
		[Address(RVA = "0xC1D3", Offset = "0xC1D3", VA = "0xC1D3")]
		public JSONData(float aData)
		{
		}

		// Token: 0x06007882 RID: 30850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007882")]
		[Address(RVA = "0xC1D4", Offset = "0xC1D4", VA = "0xC1D4")]
		public JSONData(double aData)
		{
		}

		// Token: 0x06007883 RID: 30851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007883")]
		[Address(RVA = "0xC1D5", Offset = "0xC1D5", VA = "0xC1D5")]
		public JSONData(bool aData)
		{
		}

		// Token: 0x06007884 RID: 30852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007884")]
		[Address(RVA = "0xC1D6", Offset = "0xC1D6", VA = "0xC1D6")]
		public JSONData(int aData)
		{
		}

		// Token: 0x06007885 RID: 30853 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007885")]
		[Address(RVA = "0xC1D7", Offset = "0xC1D7", VA = "0xC1D7", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007886 RID: 30854 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007886")]
		[Address(RVA = "0xC1D8", Offset = "0xC1D8", VA = "0xC1D8", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}

		// Token: 0x06007887 RID: 30855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007887")]
		[Address(RVA = "0xC1D9", Offset = "0xC1D9", VA = "0xC1D9", Slot = "28")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}

		// Token: 0x04003F0D RID: 16141
		[Token(Token = "0x4003F0D")]
		[FieldOffset(Offset = "0x8")]
		private string m_Data;
	}
}
