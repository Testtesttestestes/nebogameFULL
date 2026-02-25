using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.FeedbackForm.Model.Source;
using Il2CppDummyDll;
using JetBrains.Annotations;
using MVC;
using Utils;

namespace Gameplay.FeedbackForm.Model
{
	// Token: 0x0200081F RID: 2079
	[Token(Token = "0x200081F")]
	public class FeedbackFormModel : AbstractModel
	{
		// Token: 0x1700098B RID: 2443
		// (get) Token: 0x060030EC RID: 12524 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060030ED RID: 12525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700098B")]
		public FeedbackThemeOption CurrentTheme
		{
			[Token(Token = "0x60030EC")]
			[Address(RVA = "0x814E", Offset = "0x814E", VA = "0x814E")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60030ED")]
			[Address(RVA = "0x814F", Offset = "0x814F", VA = "0x814F")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700098C RID: 2444
		// (get) Token: 0x060030EE RID: 12526 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700098C")]
		[CanBeNull]
		public string UserEmail
		{
			[Token(Token = "0x60030EE")]
			[Address(RVA = "0x8150", Offset = "0x8150", VA = "0x8150")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700098D RID: 2445
		// (get) Token: 0x060030EF RID: 12527 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060030F0 RID: 12528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700098D")]
		[CanBeNull]
		public IOpToken CurrentSubmitRequest
		{
			[Token(Token = "0x60030EF")]
			[Address(RVA = "0x8151", Offset = "0x8151", VA = "0x8151")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60030F0")]
			[Address(RVA = "0x8152", Offset = "0x8152", VA = "0x8152")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700098E RID: 2446
		// (get) Token: 0x060030F1 RID: 12529 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700098E")]
		[CanBeNull]
		public new UserData User
		{
			[Token(Token = "0x60030F1")]
			[Address(RVA = "0x8153", Offset = "0x8153", VA = "0x8153")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700098F RID: 2447
		// (get) Token: 0x060030F2 RID: 12530 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060030F3 RID: 12531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700098F")]
		[NotNull]
		public IFeedbackFormSource Source
		{
			[Token(Token = "0x60030F2")]
			[Address(RVA = "0x8154", Offset = "0x8154", VA = "0x8154")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60030F3")]
			[Address(RVA = "0x8155", Offset = "0x8155", VA = "0x8155")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060030F4 RID: 12532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030F4")]
		[Address(RVA = "0x8156", Offset = "0x8156", VA = "0x8156", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x060030F5 RID: 12533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030F5")]
		[Address(RVA = "0x8157", Offset = "0x8157", VA = "0x8157")]
		public FeedbackFormModel([NotNull] IFeedbackFormSource source, int messageMinCharsCount, [CanBeNull] UserData user)
		{
		}

		// Token: 0x060030F6 RID: 12534 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60030F6")]
		[Address(RVA = "0x1AEB", Offset = "0x1AEB", VA = "0x1AEB")]
		public string GetUid()
		{
			return null;
		}

		// Token: 0x04001ABD RID: 6845
		[Token(Token = "0x4001ABD")]
		[FieldOffset(Offset = "0xC")]
		public readonly int MessageMinCharsCount;

		// Token: 0x04001AC1 RID: 6849
		[Token(Token = "0x4001AC1")]
		[FieldOffset(Offset = "0x1C")]
		[NotNull]
		public readonly List<FeedbackThemeOption> ThemesOptions;
	}
}
