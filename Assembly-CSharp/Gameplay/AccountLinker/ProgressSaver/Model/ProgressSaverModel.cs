using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Gameplay;
using Gameplay.AccountLinker.View;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;

namespace Gameplay.AccountLinker.ProgressSaver.Model
{
	// Token: 0x02000E0D RID: 3597
	[Token(Token = "0x2000E0D")]
	public class ProgressSaverModel : AbstractModel
	{
		// Token: 0x170011E4 RID: 4580
		// (get) Token: 0x06005797 RID: 22423 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005798 RID: 22424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011E4")]
		public IGame Game
		{
			[Token(Token = "0x6005797")]
			[Address(RVA = "0xA512", Offset = "0xA512", VA = "0xA512")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005798")]
			[Address(RVA = "0xA513", Offset = "0xA513", VA = "0xA513")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170011E5 RID: 4581
		// (get) Token: 0x06005799 RID: 22425 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600579A RID: 22426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011E5")]
		public OptionsMenuButton[] Buttons
		{
			[Token(Token = "0x6005799")]
			[Address(RVA = "0xA514", Offset = "0xA514", VA = "0xA514")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600579A")]
			[Address(RVA = "0xA515", Offset = "0xA515", VA = "0xA515")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600579B RID: 22427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600579B")]
		[Address(RVA = "0xA516", Offset = "0xA516", VA = "0xA516", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x0600579C RID: 22428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600579C")]
		[Address(RVA = "0xA517", Offset = "0xA517", VA = "0xA517")]
		public ProgressSaverModel(IGame game, IAuthDataProvider authDataProvider, UserData user)
		{
		}

		// Token: 0x170011E6 RID: 4582
		// (get) Token: 0x0600579D RID: 22429 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170011E6")]
		public string PlatformNick
		{
			[Token(Token = "0x600579D")]
			[Address(RVA = "0xA518", Offset = "0xA518", VA = "0xA518")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600579E RID: 22430 RVA: 0x0000F990 File Offset: 0x0000DB90
		[Token(Token = "0x600579E")]
		[Address(RVA = "0xA519", Offset = "0xA519", VA = "0xA519")]
		public SignInVariants.States GetCurrentSigninState()
		{
			return SignInVariants.States.UNKNOWN;
		}

		// Token: 0x170011E7 RID: 4583
		// (get) Token: 0x0600579F RID: 22431 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060057A0 RID: 22432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011E7")]
		public string Email
		{
			[Token(Token = "0x600579F")]
			[Address(RVA = "0xA51A", Offset = "0xA51A", VA = "0xA51A")]
			get
			{
				return null;
			}
			[Token(Token = "0x60057A0")]
			[Address(RVA = "0xA51B", Offset = "0xA51B", VA = "0xA51B")]
			set
			{
			}
		}

		// Token: 0x170011E8 RID: 4584
		// (get) Token: 0x060057A1 RID: 22433 RVA: 0x0000F9A8 File Offset: 0x0000DBA8
		[Token(Token = "0x170011E8")]
		public bool IsEmailActivated
		{
			[Token(Token = "0x60057A1")]
			[Address(RVA = "0xA51C", Offset = "0xA51C", VA = "0xA51C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x04002F7E RID: 12158
		[Token(Token = "0x4002F7E")]
		public const float TOAST_DURATION_ABOUT_EMAIL_SUBMITED_SUCCESS = 4f;

		// Token: 0x04002F7F RID: 12159
		[Token(Token = "0x4002F7F")]
		[FieldOffset(Offset = "0xC")]
		public readonly IAuthDataProvider AuthDataProvider;
	}
}
