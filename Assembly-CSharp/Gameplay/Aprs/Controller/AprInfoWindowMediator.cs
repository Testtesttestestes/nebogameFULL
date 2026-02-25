using System;
using Core.Dict.DictWrappers.Wrappers;
using Gameplay.Aprs.Events;
using Gameplay.Aprs.Model;
using Gameplay.Aprs.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Aprs.Controller
{
	// Token: 0x02000D70 RID: 3440
	[Token(Token = "0x2000D70")]
	public class AprInfoWindowMediator : AbstractViewMediator<AprsModel, AprsEvents, AprsController, AprInfoWindow>
	{
		// Token: 0x06005440 RID: 21568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005440")]
		[Address(RVA = "0xA1F7", Offset = "0xA1F7", VA = "0xA1F7", Slot = "14")]
		public override void Dispose()
		{
		}

		// Token: 0x06005441 RID: 21569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005441")]
		[Address(RVA = "0xA1F8", Offset = "0xA1F8", VA = "0xA1F8")]
		public AprInfoWindowMediator(AprsModel model, AprsEvents events, AprsController controller)
		{
		}

		// Token: 0x17001126 RID: 4390
		// (set) Token: 0x06005442 RID: 21570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001126")]
		public override AprsEvents Events
		{
			[Token(Token = "0x6005442")]
			[Address(RVA = "0xA1F9", Offset = "0xA1F9", VA = "0xA1F9", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06005443 RID: 21571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005443")]
		[Address(RVA = "0xA1FA", Offset = "0xA1FA", VA = "0xA1FA")]
		private void HandleDictionariesChangeEvent()
		{
		}

		// Token: 0x06005444 RID: 21572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005444")]
		[Address(RVA = "0xA1FB", Offset = "0xA1FB", VA = "0xA1FB")]
		private void OwnerChangedEvent()
		{
		}

		// Token: 0x06005445 RID: 21573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005445")]
		[Address(RVA = "0xA1FC", Offset = "0xA1FC", VA = "0xA1FC")]
		private void AprChangedEvent(AprData aprData, uint medalId)
		{
		}

		// Token: 0x06005446 RID: 21574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005446")]
		[Address(RVA = "0xA1FD", Offset = "0xA1FD", VA = "0xA1FD")]
		private void UserOnOnUserAprChangedEvent(AprDicWrapper obj)
		{
		}

		// Token: 0x17001127 RID: 4391
		// (set) Token: 0x06005447 RID: 21575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001127")]
		public override AprInfoWindow View
		{
			[Token(Token = "0x6005447")]
			[Address(RVA = "0xA1FE", Offset = "0xA1FE", VA = "0xA1FE", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06005448 RID: 21576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005448")]
		[Address(RVA = "0xA1FF", Offset = "0xA1FF", VA = "0xA1FF")]
		private void ResetView()
		{
		}

		// Token: 0x06005449 RID: 21577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005449")]
		[Address(RVA = "0xA200", Offset = "0xA200", VA = "0xA200")]
		private void SetupView()
		{
		}

		// Token: 0x0600544A RID: 21578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600544A")]
		[Address(RVA = "0xA201", Offset = "0xA201", VA = "0xA201")]
		private void UseButtonClickHandler()
		{
		}

		// Token: 0x0600544B RID: 21579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600544B")]
		[Address(RVA = "0xA202", Offset = "0xA202", VA = "0xA202")]
		private void BuyButtonClicked()
		{
		}

		// Token: 0x0600544C RID: 21580 RVA: 0x0000F378 File Offset: 0x0000D578
		[Token(Token = "0x600544C")]
		[Address(RVA = "0xA203", Offset = "0xA203", VA = "0xA203")]
		private bool TryShowBuyAprConfirmation()
		{
			return default(bool);
		}

		// Token: 0x0600544D RID: 21581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600544D")]
		[Address(RVA = "0xA204", Offset = "0xA204", VA = "0xA204")]
		private void HandleBuyAprConfirmation(AprData data)
		{
		}

		// Token: 0x0600544E RID: 21582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600544E")]
		[Address(RVA = "0xA205", Offset = "0xA205", VA = "0xA205")]
		private void ShowNext()
		{
		}

		// Token: 0x0600544F RID: 21583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600544F")]
		[Address(RVA = "0xA206", Offset = "0xA206", VA = "0xA206")]
		private void ShowPrev()
		{
		}

		// Token: 0x06005450 RID: 21584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005450")]
		[Address(RVA = "0xA207", Offset = "0xA207", VA = "0xA207")]
		private void ShowApr(int index)
		{
		}

		// Token: 0x06005451 RID: 21585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005451")]
		[Address(RVA = "0xA208", Offset = "0xA208", VA = "0xA208")]
		private void ShowApr(AprData aprData)
		{
		}

		// Token: 0x06005452 RID: 21586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005452")]
		[Address(RVA = "0xA209", Offset = "0xA209", VA = "0xA209")]
		private void ValidateOpportunityToBuy(AprData data)
		{
		}

		// Token: 0x04002DA4 RID: 11684
		[Token(Token = "0x4002DA4")]
		[FieldOffset(Offset = "0x18")]
		private int _currentIndex;

		// Token: 0x04002DA5 RID: 11685
		[Token(Token = "0x4002DA5")]
		[FieldOffset(Offset = "0x1C")]
		private AprData _currentAprData;
	}
}
