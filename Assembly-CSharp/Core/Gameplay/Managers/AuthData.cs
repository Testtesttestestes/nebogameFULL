using System;
using Core.Application.Managers;
using Il2CppDummyDll;
using Protocol.Auth2;
using Protocol.Tutorial;

namespace Core.Gameplay.Managers
{
	// Token: 0x0200112E RID: 4398
	[Token(Token = "0x200112E")]
	public class AuthData
	{
		// Token: 0x17001522 RID: 5410
		// (get) Token: 0x06006710 RID: 26384 RVA: 0x000137A0 File Offset: 0x000119A0
		[Token(Token = "0x17001522")]
		public bool IsTester
		{
			[Token(Token = "0x6006710")]
			[Address(RVA = "0xB248", Offset = "0xB248", VA = "0xB248")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06006711 RID: 26385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006711")]
		[Address(RVA = "0xB249", Offset = "0xB249", VA = "0xB249")]
		public AuthData(LoginCmd.Types.Ans loginAns, SigninRecord signinRecord)
		{
		}

		// Token: 0x06006712 RID: 26386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006712")]
		[Address(RVA = "0xB24A", Offset = "0xB24A", VA = "0xB24A")]
		public AuthData(RegisterCmd.Types.Ans registerAns, SigninRecord signinRecord)
		{
		}

		// Token: 0x06006713 RID: 26387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006713")]
		[Address(RVA = "0xB24B", Offset = "0xB24B", VA = "0xB24B")]
		public AuthData(ProtoStartTutorialAns tutorialAns, string identityCode)
		{
		}

		// Token: 0x06006714 RID: 26388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006714")]
		[Address(RVA = "0xB24C", Offset = "0xB24C", VA = "0xB24C")]
		public AuthData(ulong userId, string sessionId, string dictPath, string dictName, string cdnPath, string email, uint userFlags)
		{
		}

		// Token: 0x06006715 RID: 26389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006715")]
		[Address(RVA = "0xB24D", Offset = "0xB24D", VA = "0xB24D")]
		public AuthData(ulong userId, string sessionId, string dictPath, string dictName, string cdnPath)
		{
		}

		// Token: 0x06006716 RID: 26390 RVA: 0x000137B8 File Offset: 0x000119B8
		[Token(Token = "0x6006716")]
		[Address(RVA = "0xB24E", Offset = "0xB24E", VA = "0xB24E")]
		public bool CheckData()
		{
			return default(bool);
		}

		// Token: 0x06006717 RID: 26391 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006717")]
		[Address(RVA = "0xB24F", Offset = "0xB24F", VA = "0xB24F", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040036F8 RID: 14072
		[Token(Token = "0x40036F8")]
		[FieldOffset(Offset = "0x8")]
		public ulong UserId;

		// Token: 0x040036F9 RID: 14073
		[Token(Token = "0x40036F9")]
		[FieldOffset(Offset = "0x10")]
		public string Email;

		// Token: 0x040036FA RID: 14074
		[Token(Token = "0x40036FA")]
		[FieldOffset(Offset = "0x14")]
		public readonly string SessionId;

		// Token: 0x040036FB RID: 14075
		[Token(Token = "0x40036FB")]
		[FieldOffset(Offset = "0x18")]
		public readonly string DictPath;

		// Token: 0x040036FC RID: 14076
		[Token(Token = "0x40036FC")]
		[FieldOffset(Offset = "0x1C")]
		public readonly string CdnPath;

		// Token: 0x040036FD RID: 14077
		[Token(Token = "0x40036FD")]
		[FieldOffset(Offset = "0x20")]
		public readonly string IdentityCode;

		// Token: 0x040036FE RID: 14078
		[Token(Token = "0x40036FE")]
		[FieldOffset(Offset = "0x24")]
		public readonly uint UserFlags;

		// Token: 0x040036FF RID: 14079
		[Token(Token = "0x40036FF")]
		[FieldOffset(Offset = "0x28")]
		public readonly bool Update;

		// Token: 0x04003700 RID: 14080
		[Token(Token = "0x4003700")]
		[FieldOffset(Offset = "0x29")]
		public readonly bool IsPaymateAvail;

		// Token: 0x04003701 RID: 14081
		[Token(Token = "0x4003701")]
		[FieldOffset(Offset = "0x2C")]
		public readonly LoginCmd.Types.Result LoginResult;

		// Token: 0x04003702 RID: 14082
		[Token(Token = "0x4003702")]
		[FieldOffset(Offset = "0x30")]
		public readonly RegisterCmd.Types.Result RegisterResult;

		// Token: 0x04003703 RID: 14083
		[Token(Token = "0x4003703")]
		[FieldOffset(Offset = "0x34")]
		public readonly SigninRecord SigninRecord;

		// Token: 0x04003704 RID: 14084
		[Token(Token = "0x4003704")]
		[FieldOffset(Offset = "0x38")]
		public readonly IDictNameSource DictNameSource;
	}
}
