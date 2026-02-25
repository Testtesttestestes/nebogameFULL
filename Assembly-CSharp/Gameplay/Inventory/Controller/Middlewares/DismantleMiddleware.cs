using System;
using Core.Data;
using Core.Dict;
using Core.Dict.DictWrappers.Wrappers;
using Core.Gameplay.Managers.GameActivityRouting;
using Il2CppDummyDll;
using Protocol.Consts;
using UI.ConfirmationMessage;
using UI.Toast;
using UI.Windows;

namespace Gameplay.Inventory.Controller.Middlewares
{
	// Token: 0x020006BE RID: 1726
	[Token(Token = "0x20006BE")]
	public sealed class DismantleMiddleware
	{
		// Token: 0x060029CC RID: 10700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029CC")]
		[Address(RVA = "0x7A82", Offset = "0x7A82", VA = "0x7A82")]
		public DismantleMiddleware(IDictProvider dictProvider, GameFeatureRouterManager featureRouter, ConfirmationMessageController confirmationMessage, ToastController toastController, ArtikulTypes recipeArtikulType)
		{
		}

		// Token: 0x060029CD RID: 10701 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60029CD")]
		[Address(RVA = "0x7A83", Offset = "0x7A83", VA = "0x7A83")]
		private DialogWindow ShowRecipeLearnedWindow(string title, ArtikulDicWrapper artikul, IDictProvider dictProvider)
		{
			return null;
		}

		// Token: 0x060029CE RID: 10702 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60029CE")]
		[Address(RVA = "0x7A84", Offset = "0x7A84", VA = "0x7A84")]
		private string GetText(ArtifactData artifact)
		{
			return null;
		}

		// Token: 0x060029CF RID: 10703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029CF")]
		[Address(RVA = "0x7A85", Offset = "0x7A85", VA = "0x7A85")]
		public void Notify(ArtifactData artifact)
		{
		}

		// Token: 0x060029D0 RID: 10704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029D0")]
		[Address(RVA = "0x7A86", Offset = "0x7A86", VA = "0x7A86")]
		public void Notify(ArtifactData artifact, ToastTheme theme)
		{
		}

		// Token: 0x0400172B RID: 5931
		[Token(Token = "0x400172B")]
		[FieldOffset(Offset = "0x8")]
		private readonly IDictProvider _dictProvider;

		// Token: 0x0400172C RID: 5932
		[Token(Token = "0x400172C")]
		[FieldOffset(Offset = "0xC")]
		private readonly GameFeatureRouterManager _featureRouter;

		// Token: 0x0400172D RID: 5933
		[Token(Token = "0x400172D")]
		[FieldOffset(Offset = "0x10")]
		private readonly ConfirmationMessageController _confirmationMessage;

		// Token: 0x0400172E RID: 5934
		[Token(Token = "0x400172E")]
		[FieldOffset(Offset = "0x14")]
		private readonly ToastController _toastController;

		// Token: 0x0400172F RID: 5935
		[Token(Token = "0x400172F")]
		[FieldOffset(Offset = "0x18")]
		private readonly ArtikulTypes _recipeArtikulType;
	}
}
