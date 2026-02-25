using System;
using System.Collections;
using Gameplay.User.Events;
using Gameplay.User.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Auth;
using Protocol.Balance;
using Protocol.Clans;
using Protocol.Common;
using Protocol.Craft;
using Protocol.Main;
using Protocol.Tree;
using Protocol.World;
using ServicesNamespace;
using UnityEngine;
using Utils;

namespace Gameplay.User.Controller
{
	// Token: 0x02000422 RID: 1058
	[Token(Token = "0x2000422")]
	public class UserController : AbstractController<UserModel, UserEvents>
	{
		// Token: 0x06001901 RID: 6401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001901")]
		[Address(RVA = "0x6AA0", Offset = "0x6AA0", VA = "0x6AA0")]
		public UserController(UserModel model, UserEvents events)
		{
		}

		// Token: 0x06001902 RID: 6402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001902")]
		[Address(RVA = "0x6AA1", Offset = "0x6AA1", VA = "0x6AA1", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06001903 RID: 6403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001903")]
		[Address(RVA = "0x6AA2", Offset = "0x6AA2", VA = "0x6AA2", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x06001904 RID: 6404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001904")]
		[Address(RVA = "0x6AA3", Offset = "0x6AA3", VA = "0x6AA3", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x06001905 RID: 6405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001905")]
		[Address(RVA = "0x6AA4", Offset = "0x6AA4", VA = "0x6AA4")]
		private void ClanUnregisteredHandler(ProtoUnregisterClanAns ans)
		{
		}

		// Token: 0x06001906 RID: 6406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001906")]
		[Address(RVA = "0x6AA5", Offset = "0x6AA5", VA = "0x6AA5")]
		private void UserLeftClanEventHandler(ProtoUserLeftClanEvt evt)
		{
		}

		// Token: 0x06001907 RID: 6407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001907")]
		[Address(RVA = "0x6AA6", Offset = "0x6AA6", VA = "0x6AA6")]
		private void UserAprChangedEventHandler(ProtoUserAprChangedEvt evt)
		{
		}

		// Token: 0x06001908 RID: 6408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001908")]
		[Address(RVA = "0x6AA7", Offset = "0x6AA7", VA = "0x6AA7")]
		private void BanStatusChangedEventHandler(ProtoBanStatusChangedEvt evt)
		{
		}

		// Token: 0x06001909 RID: 6409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001909")]
		[Address(RVA = "0x6AA8", Offset = "0x6AA8", VA = "0x6AA8")]
		private void TakeOffMedalsEventHandler(ProtoTakeOffMedalsEvt evt)
		{
		}

		// Token: 0x0600190A RID: 6410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600190A")]
		[Address(RVA = "0x6AA9", Offset = "0x6AA9", VA = "0x6AA9")]
		private void MainServiceOnSkillsChangedEvent(ProtoSkillsChangedEvt evt)
		{
		}

		// Token: 0x0600190B RID: 6411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600190B")]
		[Address(RVA = "0x6AAA", Offset = "0x6AAA", VA = "0x6AAA")]
		public void BuyNextLevel()
		{
		}

		// Token: 0x0600190C RID: 6412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600190C")]
		[Address(RVA = "0x6AAB", Offset = "0x6AAB", VA = "0x6AAB")]
		private void HandlerServiceBuyNextLevel(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x0600190D RID: 6413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600190D")]
		[Address(RVA = "0x6AAC", Offset = "0x6AAC", VA = "0x6AAC")]
		public void PayoffBan()
		{
		}

		// Token: 0x0600190E RID: 6414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600190E")]
		[Address(RVA = "0x6AAD", Offset = "0x6AAD", VA = "0x6AAD")]
		private void PayoffBanResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x0600190F RID: 6415 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600190F")]
		[Address(RVA = "0x6AAE", Offset = "0x6AAE", VA = "0x6AAE")]
		public OpToken<bool, int> BuyLicense()
		{
			return null;
		}

		// Token: 0x06001910 RID: 6416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001910")]
		[Address(RVA = "0x6AAF", Offset = "0x6AAF", VA = "0x6AAF")]
		private void BuyLicenseServerHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06001911 RID: 6417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001911")]
		[Address(RVA = "0x6AB0", Offset = "0x6AB0", VA = "0x6AB0")]
		private void HandelGetUserBalanceService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06001912 RID: 6418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001912")]
		[Address(RVA = "0x6AB1", Offset = "0x6AB1", VA = "0x6AB1")]
		private void HandleGetOwnClanInfoService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06001913 RID: 6419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001913")]
		[Address(RVA = "0x6AB2", Offset = "0x6AB2", VA = "0x6AB2")]
		public void UpdateUserInfo()
		{
		}

		// Token: 0x06001914 RID: 6420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001914")]
		[Address(RVA = "0x6AB3", Offset = "0x6AB3", VA = "0x6AB3")]
		public void SetBalance(NullableResourceSet value)
		{
		}

		// Token: 0x06001915 RID: 6421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001915")]
		[Address(RVA = "0x6AB4", Offset = "0x6AB4", VA = "0x6AB4")]
		private void HandleGetUserInfoService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06001916 RID: 6422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001916")]
		[Address(RVA = "0x6AB5", Offset = "0x6AB5", VA = "0x6AB5")]
		private void UpdateEnergyRegenStatus()
		{
		}

		// Token: 0x06001917 RID: 6423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001917")]
		[Address(RVA = "0x6AB6", Offset = "0x6AB6", VA = "0x6AB6")]
		private void HandleGetEnergyRegenStatusService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06001918 RID: 6424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001918")]
		[Address(RVA = "0x6AB7", Offset = "0x6AB7", VA = "0x6AB7")]
		private void SetEnergyRegenStatus(double energy, EnergyRegenStatus value)
		{
		}

		// Token: 0x06001919 RID: 6425 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001919")]
		[Address(RVA = "0x6AB8", Offset = "0x6AB8", VA = "0x6AB8")]
		private IEnumerator EnergyRecoveryCoroutine(float seconds)
		{
			return null;
		}

		// Token: 0x0600191A RID: 6426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600191A")]
		[Address(RVA = "0x6AB9", Offset = "0x6AB9", VA = "0x6AB9")]
		private void StopEnergyRecoveryCoroutine()
		{
		}

		// Token: 0x0600191B RID: 6427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600191B")]
		[Address(RVA = "0x6ABA", Offset = "0x6ABA", VA = "0x6ABA")]
		private void GetUserProfessionsResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x0600191C RID: 6428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600191C")]
		[Address(RVA = "0x6ABB", Offset = "0x6ABB", VA = "0x6ABB")]
		private void HandleInit()
		{
		}

		// Token: 0x0600191D RID: 6429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600191D")]
		[Address(RVA = "0x6ABC", Offset = "0x6ABC", VA = "0x6ABC")]
		private void HandleTriggersChangedEvent(ProtoTriggersChangedEvt msg)
		{
		}

		// Token: 0x0600191E RID: 6430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600191E")]
		[Address(RVA = "0x6ABD", Offset = "0x6ABD", VA = "0x6ABD")]
		private void HandleBalanceChangedEventService(ProtoResourcesChangedEvt evt)
		{
		}

		// Token: 0x0600191F RID: 6431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600191F")]
		[Address(RVA = "0x6ABE", Offset = "0x6ABE", VA = "0x6ABE")]
		private void HandleNewLevelEvent(ProtoNewLevelEvt evt)
		{
		}

		// Token: 0x06001920 RID: 6432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001920")]
		[Address(RVA = "0x6ABF", Offset = "0x6ABF", VA = "0x6ABF")]
		private void HandleExpChangedEvent(ProtoExperienceChangedEvt evt)
		{
		}

		// Token: 0x06001921 RID: 6433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001921")]
		[Address(RVA = "0x6AC0", Offset = "0x6AC0", VA = "0x6AC0")]
		private void HandleTreeRegenEvent(ProtoRegenTreeEvt evt)
		{
		}

		// Token: 0x06001922 RID: 6434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001922")]
		[Address(RVA = "0x6AC1", Offset = "0x6AC1", VA = "0x6AC1")]
		private void ProfessionChangedEventHandler(UserProfession profession)
		{
		}

		// Token: 0x06001923 RID: 6435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001923")]
		[Address(RVA = "0x6AC2", Offset = "0x6AC2", VA = "0x6AC2")]
		private void SetLevel(uint value)
		{
		}

		// Token: 0x04000D3C RID: 3388
		[Token(Token = "0x4000D3C")]
		[FieldOffset(Offset = "0x18")]
		private MainService _mainService;

		// Token: 0x04000D3D RID: 3389
		[Token(Token = "0x4000D3D")]
		[FieldOffset(Offset = "0x1C")]
		private WorldService _worldService;

		// Token: 0x04000D3E RID: 3390
		[Token(Token = "0x4000D3E")]
		[FieldOffset(Offset = "0x20")]
		private ClansService _clansService;

		// Token: 0x04000D3F RID: 3391
		[Token(Token = "0x4000D3F")]
		[FieldOffset(Offset = "0x24")]
		private Coroutine _energyRecoveryCoroutine;
	}
}
