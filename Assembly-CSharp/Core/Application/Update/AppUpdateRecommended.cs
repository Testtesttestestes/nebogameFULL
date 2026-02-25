using System;
using Core.Application.Update.Common;
using Core.Gameplay;
using Gameplay.UserInterface.View.Update;
using Il2CppDummyDll;
using UI;
using UI.Windows;
using UnityEngine.EventSystems;

namespace Core.Application.Update
{
	// Token: 0x02001237 RID: 4663
	[Token(Token = "0x2001237")]
	public class AppUpdateRecommended : AbstractAppUpdateRecommended
	{
		// Token: 0x06006EAD RID: 28333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EAD")]
		[Address(RVA = "0xB931", Offset = "0xB931", VA = "0xB931")]
		public AppUpdateRecommended(IApp app, IAuthDataProvider authDataProvider, RecommendedAppUpdateView entryPointView, IProgress progressView)
		{
		}

		// Token: 0x06006EAE RID: 28334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EAE")]
		[Address(RVA = "0xB932", Offset = "0xB932", VA = "0xB932", Slot = "7")]
		public override void Run()
		{
		}

		// Token: 0x06006EAF RID: 28335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EAF")]
		[Address(RVA = "0xB933", Offset = "0xB933", VA = "0xB933", Slot = "8")]
		public override void Stop()
		{
		}

		// Token: 0x06006EB0 RID: 28336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EB0")]
		[Address(RVA = "0xB934", Offset = "0xB934", VA = "0xB934")]
		private void EntryPointViewOnOnClickEvent(PointerEventData obj)
		{
		}

		// Token: 0x06006EB1 RID: 28337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EB1")]
		[Address(RVA = "0xB935", Offset = "0xB935", VA = "0xB935", Slot = "10")]
		protected override void ConfirmAboutRecommendedAppUpdateCallback(BaseDialogWindow<DialogWindow.DialogWindowArgs> window)
		{
		}
	}
}
