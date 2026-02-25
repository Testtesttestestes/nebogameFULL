using System;
using Gameplay.RegisterV2.Events;
using Gameplay.RegisterV2.Model;
using Gameplay.RegisterV2.View;
using Gameplay.RegisterV2.View.GenderSelector;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using MVC;
using Protocol.Auth2;
using Protocol.Dic;
using UnityEngine.EventSystems;

namespace Gameplay.RegisterV2.Control
{
	// Token: 0x02000570 RID: 1392
	[Token(Token = "0x2000570")]
	public class RegisterMediator : AbstractViewMediator<RegisterModel, RegisterEvents, RegisterController, RegistrationView>
	{
		// Token: 0x06002178 RID: 8568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002178")]
		[Address(RVA = "0x72D7", Offset = "0x72D7", VA = "0x72D7")]
		public RegisterMediator(RegisterModel model, RegisterEvents events, RegisterController controller)
		{
		}

		// Token: 0x1700061F RID: 1567
		// (set) Token: 0x06002179 RID: 8569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700061F")]
		public override RegistrationView View
		{
			[Token(Token = "0x6002179")]
			[Address(RVA = "0x72D8", Offset = "0x72D8", VA = "0x72D8", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x17000620 RID: 1568
		// (set) Token: 0x0600217A RID: 8570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000620")]
		public override RegisterEvents Events
		{
			[Token(Token = "0x600217A")]
			[Address(RVA = "0x72D9", Offset = "0x72D9", VA = "0x72D9", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x0600217B RID: 8571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600217B")]
		[Address(RVA = "0x72DA", Offset = "0x72DA", VA = "0x72DA")]
		private void ResetEvents(RegisterEvents events)
		{
		}

		// Token: 0x0600217C RID: 8572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600217C")]
		[Address(RVA = "0x72DB", Offset = "0x72DB", VA = "0x72DB")]
		private void SetupEvents(RegisterEvents events)
		{
		}

		// Token: 0x0600217D RID: 8573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600217D")]
		[Address(RVA = "0x72DC", Offset = "0x72DC", VA = "0x72DC")]
		private void ResetView(RegistrationView view)
		{
		}

		// Token: 0x0600217E RID: 8574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600217E")]
		[Address(RVA = "0x72DD", Offset = "0x72DD", VA = "0x72DD")]
		private void SetupView(RegistrationView view)
		{
		}

		// Token: 0x0600217F RID: 8575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600217F")]
		[Address(RVA = "0x72DE", Offset = "0x72DE", VA = "0x72DE")]
		private void HandleForegroundClickEvent(PointerEventData data)
		{
		}

		// Token: 0x06002180 RID: 8576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002180")]
		[Address(RVA = "0x72DF", Offset = "0x72DF", VA = "0x72DF")]
		private void HandleGeneratedEvent()
		{
		}

		// Token: 0x06002181 RID: 8577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002181")]
		[Address(RVA = "0x72E0", Offset = "0x72E0", VA = "0x72E0")]
		private void HandleInvalidNickErrorEvent(RepeatedField<string> nickVariants, RegisterCmd.Types.Result result)
		{
		}

		// Token: 0x06002182 RID: 8578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002182")]
		[Address(RVA = "0x72E1", Offset = "0x72E1", VA = "0x72E1")]
		private void HandleInitEvent()
		{
		}

		// Token: 0x06002183 RID: 8579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002183")]
		[Address(RVA = "0x72E2", Offset = "0x72E2", VA = "0x72E2")]
		private void GenerateNick()
		{
		}

		// Token: 0x06002184 RID: 8580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002184")]
		[Address(RVA = "0x72E3", Offset = "0x72E3", VA = "0x72E3")]
		private void OnRegister()
		{
		}

		// Token: 0x06002185 RID: 8581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002185")]
		[Address(RVA = "0x72E4", Offset = "0x72E4", VA = "0x72E4")]
		private void SelectGender(GenderListElement.GenderListElementArgs args)
		{
		}

		// Token: 0x06002186 RID: 8582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002186")]
		[Address(RVA = "0x72E5", Offset = "0x72E5", VA = "0x72E5")]
		private void UpdateGenderData()
		{
		}

		// Token: 0x06002187 RID: 8583 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002187")]
		[Address(RVA = "0x72E6", Offset = "0x72E6", VA = "0x72E6")]
		private GenderListElement.GenderListElementArgs ConstructGenderArgs(AprDic dic)
		{
			return null;
		}

		// Token: 0x06002188 RID: 8584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002188")]
		[Address(RVA = "0x72E7", Offset = "0x72E7", VA = "0x72E7")]
		private void GenderListElementClickedEventHandler(GenderListElement element)
		{
		}

		// Token: 0x06002189 RID: 8585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002189")]
		[Address(RVA = "0x72E8", Offset = "0x72E8", VA = "0x72E8")]
		private void OnCultChanged(CultDic cultDic)
		{
		}

		// Token: 0x0600218A RID: 8586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600218A")]
		[Address(RVA = "0x72E9", Offset = "0x72E9", VA = "0x72E9")]
		private void OnNickChanged(string nick)
		{
		}

		// Token: 0x0600218B RID: 8587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600218B")]
		[Address(RVA = "0x72EA", Offset = "0x72EA", VA = "0x72EA")]
		private void HandleEmptyNick()
		{
		}

		// Token: 0x0400124C RID: 4684
		[Token(Token = "0x400124C")]
		[FieldOffset(Offset = "0x18")]
		private GenderListElement.GenderListElementArgs _selectedArgs;

		// Token: 0x0400124D RID: 4685
		[Token(Token = "0x400124D")]
		[FieldOffset(Offset = "0x1C")]
		private int _genderIndex;
	}
}
