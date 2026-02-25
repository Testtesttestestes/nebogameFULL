using System;
using System.Runtime.CompilerServices;
using Gameplay.World.Model;
using Il2CppDummyDll;
using Protocol.ClanIsle;
using Protocol.Dic;

namespace Gameplay.Clans.Office.Model
{
	// Token: 0x02000A45 RID: 2629
	[Token(Token = "0x2000A45")]
	public class ClanOfficeData
	{
		// Token: 0x17000C78 RID: 3192
		// (get) Token: 0x06003E3C RID: 15932 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003E3D RID: 15933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C78")]
		public ProtoGetIsleInfoAns.Types.ClanIsleInformation ClanIsleInformation
		{
			[Token(Token = "0x6003E3C")]
			[Address(RVA = "0x8CFB", Offset = "0x8CFB", VA = "0x8CFB")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E3D")]
			[Address(RVA = "0x8CFC", Offset = "0x8CFC", VA = "0x8CFC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C79 RID: 3193
		// (get) Token: 0x06003E3E RID: 15934 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003E3F RID: 15935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C79")]
		public ClanData ClanData
		{
			[Token(Token = "0x6003E3E")]
			[Address(RVA = "0x8CFD", Offset = "0x8CFD", VA = "0x8CFD")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E3F")]
			[Address(RVA = "0x8CFE", Offset = "0x8CFE", VA = "0x8CFE")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C7A RID: 3194
		// (get) Token: 0x06003E40 RID: 15936 RVA: 0x0000C480 File Offset: 0x0000A680
		// (set) Token: 0x06003E41 RID: 15937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C7A")]
		public int MembersCount
		{
			[Token(Token = "0x6003E40")]
			[Address(RVA = "0x8CFF", Offset = "0x8CFF", VA = "0x8CFF")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003E41")]
			[Address(RVA = "0x8D00", Offset = "0x8D00", VA = "0x8D00")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06003E42 RID: 15938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E42")]
		[Address(RVA = "0x8D01", Offset = "0x8D01", VA = "0x8D01")]
		private ClanOfficeData()
		{
		}

		// Token: 0x06003E43 RID: 15939 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003E43")]
		[Address(RVA = "0x8D02", Offset = "0x8D02", VA = "0x8D02")]
		public static ClanOfficeData Create(ProtoGetIsleInfoAns.Types.ClanIsleInformation clanIsleInformation, Dictionaries dictionaries)
		{
			return null;
		}
	}
}
