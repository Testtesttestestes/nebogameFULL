using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Core.Application.Managers.Configuration.Curator
{
	// Token: 0x02001270 RID: 4720
	[Token(Token = "0x2001270")]
	[Serializable]
	public class CuratorData
	{
		// Token: 0x170016DD RID: 5853
		// (get) Token: 0x06007008 RID: 28680 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06007009 RID: 28681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016DD")]
		public string ClientIp
		{
			[Token(Token = "0x6007008")]
			[Address(RVA = "0xBA55", Offset = "0xBA55", VA = "0xBA55")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6007009")]
			[Address(RVA = "0xBA56", Offset = "0xBA56", VA = "0xBA56")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170016DE RID: 5854
		// (get) Token: 0x0600700A RID: 28682 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600700B RID: 28683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016DE")]
		public string Country
		{
			[Token(Token = "0x600700A")]
			[Address(RVA = "0xBA57", Offset = "0xBA57", VA = "0xBA57")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600700B")]
			[Address(RVA = "0xBA58", Offset = "0xBA58", VA = "0xBA58")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170016DF RID: 5855
		// (get) Token: 0x0600700C RID: 28684 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600700D RID: 28685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016DF")]
		public string Server
		{
			[Token(Token = "0x600700C")]
			[Address(RVA = "0xBA59", Offset = "0xBA59", VA = "0xBA59")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600700D")]
			[Address(RVA = "0xBA5A", Offset = "0xBA5A", VA = "0xBA5A")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600700E RID: 28686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600700E")]
		[Address(RVA = "0xBA5B", Offset = "0xBA5B", VA = "0xBA5B")]
		public CuratorData(Uri endpoint)
		{
		}

		// Token: 0x0600700F RID: 28687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600700F")]
		[Address(RVA = "0xBA5C", Offset = "0xBA5C", VA = "0xBA5C")]
		public CuratorData(Uri endpoint, string server)
		{
		}

		// Token: 0x06007010 RID: 28688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007010")]
		[Address(RVA = "0xBA5D", Offset = "0xBA5D", VA = "0xBA5D")]
		public CuratorData(Uri endpoint, string server, string clientIp, string country)
		{
		}

		// Token: 0x06007011 RID: 28689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007011")]
		[Address(RVA = "0xBA5E", Offset = "0xBA5E", VA = "0xBA5E")]
		public void SetServer(string v)
		{
		}

		// Token: 0x06007012 RID: 28690 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007012")]
		[Address(RVA = "0xBA5F", Offset = "0xBA5F", VA = "0xBA5F", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04003A75 RID: 14965
		[Token(Token = "0x4003A75")]
		[FieldOffset(Offset = "0x8")]
		public readonly Uri Endpoint;
	}
}
