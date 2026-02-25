using System;
using System.Runtime.CompilerServices;
using Gameplay.Portals.Events;
using Gameplay.Portals.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Portal;
using ServicesNamespace;
using Utils;

namespace Gameplay.Portals.Controller
{
	// Token: 0x020005DA RID: 1498
	[Token(Token = "0x20005DA")]
	public class PortalsController : AbstractController<PortalsModel, PortalsEvents>
	{
		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x0600240A RID: 9226 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006D0")]
		public PortalsService PortalsService
		{
			[Token(Token = "0x600240A")]
			[Address(RVA = "0x755B", Offset = "0x755B", VA = "0x755B")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x0600240B RID: 9227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600240B")]
		[Address(RVA = "0x755C", Offset = "0x755C", VA = "0x755C")]
		public PortalsController(PortalsModel model, PortalsEvents events, PortalsService portalsService)
		{
		}

		// Token: 0x0600240C RID: 9228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600240C")]
		[Address(RVA = "0x755D", Offset = "0x755D", VA = "0x755D", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x0600240D RID: 9229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600240D")]
		[Address(RVA = "0x755E", Offset = "0x755E", VA = "0x755E", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x0600240E RID: 9230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600240E")]
		[Address(RVA = "0x755F", Offset = "0x755F", VA = "0x755F")]
		private void UserBetChangedHandler(ProtoPortalUserBetChangedEvt msg)
		{
		}

		// Token: 0x0600240F RID: 9231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600240F")]
		[Address(RVA = "0x7560", Offset = "0x7560", VA = "0x7560")]
		private void UserInfoChangedHandler(ProtoPortalUserInfoChangedEvt msg)
		{
		}

		// Token: 0x06002410 RID: 9232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002410")]
		[Address(RVA = "0x7561", Offset = "0x7561", VA = "0x7561")]
		private void ProtoPortalMonsterInfoChangedEventHandler(ProtoPortalMonsterInfoChangedEvt msg)
		{
		}

		// Token: 0x06002411 RID: 9233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002411")]
		[Address(RVA = "0x7562", Offset = "0x7562", VA = "0x7562")]
		private void PortalStartedHandler(ProtoPortalStartedEvt msg)
		{
		}

		// Token: 0x06002412 RID: 9234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002412")]
		[Address(RVA = "0x7563", Offset = "0x7563", VA = "0x7563")]
		private void PortalDoneHandler(ProtoPortalDoneEvt msg)
		{
		}

		// Token: 0x06002413 RID: 9235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002413")]
		[Address(RVA = "0x7564", Offset = "0x7564", VA = "0x7564")]
		private void PortalStageInfoChangedEventHandler(ProtoPortalStageInfoChangedEvt msg)
		{
		}

		// Token: 0x06002414 RID: 9236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002414")]
		[Address(RVA = "0x7565", Offset = "0x7565", VA = "0x7565")]
		private void UpdateStageDic()
		{
		}

		// Token: 0x06002415 RID: 9237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002415")]
		[Address(RVA = "0x7566", Offset = "0x7566", VA = "0x7566")]
		public void RegisterUser()
		{
		}

		// Token: 0x06002416 RID: 9238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002416")]
		[Address(RVA = "0x7567", Offset = "0x7567", VA = "0x7567")]
		public void Subscribe()
		{
		}

		// Token: 0x06002417 RID: 9239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002417")]
		[Address(RVA = "0x7568", Offset = "0x7568", VA = "0x7568")]
		public void Unsubscribe()
		{
		}

		// Token: 0x06002418 RID: 9240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002418")]
		[Address(RVA = "0x7569", Offset = "0x7569", VA = "0x7569")]
		public void GetPortalInfo()
		{
		}

		// Token: 0x06002419 RID: 9241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002419")]
		[Address(RVA = "0x1BEB", Offset = "0x1BEB", VA = "0x1BEB")]
		public void GetStageInfo()
		{
		}

		// Token: 0x0600241A RID: 9242 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600241A")]
		[Address(RVA = "0x1BEC", Offset = "0x1BEC", VA = "0x1BEC")]
		public OpToken<IMessage, object> GetCurrentMonster()
		{
			return null;
		}

		// Token: 0x0600241B RID: 9243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600241B")]
		[Address(RVA = "0x756A", Offset = "0x756A", VA = "0x756A")]
		public void AttackMonster()
		{
		}

		// Token: 0x0600241C RID: 9244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600241C")]
		[Address(RVA = "0x756B", Offset = "0x756B", VA = "0x756B")]
		public void ComebackToStage()
		{
		}

		// Token: 0x0600241D RID: 9245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600241D")]
		[Address(RVA = "0x756C", Offset = "0x756C", VA = "0x756C")]
		public void GetBetPoolInfo()
		{
		}

		// Token: 0x0600241E RID: 9246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600241E")]
		[Address(RVA = "0x756D", Offset = "0x756D", VA = "0x756D")]
		public void GetJackpotInfo()
		{
		}

		// Token: 0x0600241F RID: 9247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600241F")]
		[Address(RVA = "0x756E", Offset = "0x756E", VA = "0x756E")]
		private void RegisterUserHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06002420 RID: 9248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002420")]
		[Address(RVA = "0x756F", Offset = "0x756F", VA = "0x756F")]
		private void SubscribeHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06002421 RID: 9249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002421")]
		[Address(RVA = "0x7570", Offset = "0x7570", VA = "0x7570")]
		private void UnsubscribeHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06002422 RID: 9250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002422")]
		[Address(RVA = "0x7571", Offset = "0x7571", VA = "0x7571")]
		private void GetPortalInfoHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06002423 RID: 9251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002423")]
		[Address(RVA = "0x7572", Offset = "0x7572", VA = "0x7572")]
		private void SetEntryPointBackTime()
		{
		}

		// Token: 0x06002424 RID: 9252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002424")]
		[Address(RVA = "0x7573", Offset = "0x7573", VA = "0x7573")]
		private void UpdateCurrentPortalDic(uint portalId)
		{
		}

		// Token: 0x06002425 RID: 9253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002425")]
		[Address(RVA = "0x7574", Offset = "0x7574", VA = "0x7574")]
		private void GetStageInfoHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06002426 RID: 9254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002426")]
		[Address(RVA = "0x7575", Offset = "0x7575", VA = "0x7575")]
		private void ComebackToStageHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06002427 RID: 9255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002427")]
		[Address(RVA = "0x7576", Offset = "0x7576", VA = "0x7576")]
		private void GetBetPoolInfoHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06002428 RID: 9256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002428")]
		[Address(RVA = "0x7577", Offset = "0x7577", VA = "0x7577")]
		private void GetJackpotInfoHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06002429 RID: 9257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002429")]
		[Address(RVA = "0x7578", Offset = "0x7578", VA = "0x7578")]
		private void GetCurrentMonsterInfoHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x0600242A RID: 9258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600242A")]
		[Address(RVA = "0x7579", Offset = "0x7579", VA = "0x7579")]
		private void AttackSuccessHandler()
		{
		}

		// Token: 0x0600242B RID: 9259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600242B")]
		[Address(RVA = "0x757A", Offset = "0x757A", VA = "0x757A")]
		private void ValidateInit()
		{
		}
	}
}
