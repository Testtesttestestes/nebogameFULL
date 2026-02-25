using System;
using Core.Data;
using Cysharp.Threading.Tasks;
using Gameplay.Medals.Events;
using Gameplay.Medals.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Main;
using ServicesNamespace;
using Utils;

namespace Gameplay.Medals.Controller
{
	// Token: 0x0200060C RID: 1548
	[Token(Token = "0x200060C")]
	public class MedalsController : AbstractController<MedalsModel, MedalsEvents>
	{
		// Token: 0x06002592 RID: 9618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002592")]
		[Address(RVA = "0x76D6", Offset = "0x76D6", VA = "0x76D6", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06002593 RID: 9619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002593")]
		[Address(RVA = "0x76D7", Offset = "0x76D7", VA = "0x76D7")]
		public MedalsController(MedalsModel model, MedalsEvents events)
		{
		}

		// Token: 0x06002594 RID: 9620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002594")]
		[Address(RVA = "0x76D8", Offset = "0x76D8", VA = "0x76D8", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x06002595 RID: 9621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002595")]
		[Address(RVA = "0x76D9", Offset = "0x76D9", VA = "0x76D9")]
		private void MainServiceOnTakeOffMedalsEvent(ProtoTakeOffMedalsEvt evt)
		{
		}

		// Token: 0x06002596 RID: 9622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002596")]
		[Address(RVA = "0x76DA", Offset = "0x76DA", VA = "0x76DA")]
		private void MainServiceOnNewMedalsEvent(ProtoNewMedalsEvt evt)
		{
		}

		// Token: 0x06002597 RID: 9623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002597")]
		[Address(RVA = "0x76DB", Offset = "0x76DB", VA = "0x76DB")]
		private void ShowNewMedalToast(uint medalId)
		{
		}

		// Token: 0x06002598 RID: 9624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002598")]
		[Address(RVA = "0x76DC", Offset = "0x76DC", VA = "0x76DC")]
		private void UserCacheResultCallback(long operationIndex, params UserData[] data)
		{
		}

		// Token: 0x06002599 RID: 9625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002599")]
		[Address(RVA = "0x76DD", Offset = "0x76DD", VA = "0x76DD")]
		private void ValidateInit()
		{
		}

		// Token: 0x0600259A RID: 9626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600259A")]
		[Address(RVA = "0x76DE", Offset = "0x76DE", VA = "0x76DE", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x0600259B RID: 9627 RVA: 0x00007290 File Offset: 0x00005490
		[Token(Token = "0x600259B")]
		[Address(RVA = "0x1C14", Offset = "0x1C14", VA = "0x1C14")]
		public UniTask<bool> BuyMedal(MedalData medalData)
		{
			return default(UniTask<bool>);
		}

		// Token: 0x0600259C RID: 9628 RVA: 0x000072A8 File Offset: 0x000054A8
		[Token(Token = "0x600259C")]
		[Address(RVA = "0x1E4D", Offset = "0x1E4D", VA = "0x1E4D")]
		public UniTask BuyMedal(uint medalId)
		{
			return default(UniTask);
		}

		// Token: 0x0600259D RID: 9629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600259D")]
		[Address(RVA = "0x76DF", Offset = "0x76DF", VA = "0x76DF")]
		private void HandleBuyMedalService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x0600259E RID: 9630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600259E")]
		[Address(RVA = "0x1C1A", Offset = "0x1C1A", VA = "0x1C1A")]
		private void HandleMedalAdded(MedalInfo medalInfo)
		{
		}

		// Token: 0x04001491 RID: 5265
		[Token(Token = "0x4001491")]
		[FieldOffset(Offset = "0x18")]
		private MainService _mainService;

		// Token: 0x04001492 RID: 5266
		[Token(Token = "0x4001492")]
		[FieldOffset(Offset = "0x1C")]
		private ServicesService _servicesService;
	}
}
