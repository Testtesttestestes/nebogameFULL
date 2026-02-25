using System;
using System.Collections.Generic;
using CloudsFly.Movement;
using Gameplay.UserInterface.Events;
using Gameplay.UserInterface.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;
using Utils;
using Utils.Accumulators;

namespace Gameplay.UserInterface.Control
{
	// Token: 0x020003EC RID: 1004
	[Token(Token = "0x20003EC")]
	public class UserInterfaceController : AbstractController<UserInterfaceModel, UserInterfaceEvents>
	{
		// Token: 0x06001767 RID: 5991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001767")]
		[Address(RVA = "0x6923", Offset = "0x6923", VA = "0x6923")]
		public UserInterfaceController(UserInterfaceModel model, UserInterfaceEvents events)
		{
		}

		// Token: 0x06001768 RID: 5992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001768")]
		[Address(RVA = "0x6924", Offset = "0x6924", VA = "0x6924", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x06001769 RID: 5993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001769")]
		[Address(RVA = "0x6925", Offset = "0x6925", VA = "0x6925", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x0600176A RID: 5994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600176A")]
		[Address(RVA = "0x6926", Offset = "0x6926", VA = "0x6926")]
		private void HandleScenesLoadedEvent(string sceneName)
		{
		}

		// Token: 0x0600176B RID: 5995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600176B")]
		[Address(RVA = "0x6927", Offset = "0x6927", VA = "0x6927")]
		private void HandleScenesUnloadEvent(string sceneName)
		{
		}

		// Token: 0x0600176C RID: 5996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600176C")]
		[Address(RVA = "0x6928", Offset = "0x6928", VA = "0x6928")]
		private void HandleWorldEngineMoveCompleteEvent(WorldMovementTypes movementType)
		{
		}

		// Token: 0x0600176D RID: 5997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600176D")]
		[Address(RVA = "0x6929", Offset = "0x6929", VA = "0x6929")]
		private void HandleWorldEngineMoveStartEvent(WorldMovementTypes movementType)
		{
		}

		// Token: 0x0600176E RID: 5998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600176E")]
		[Address(RVA = "0x692A", Offset = "0x692A", VA = "0x692A")]
		private void HandleUserTriggersEvent(IEnumerable<TriggerValue> changes, AccumulatorBase<int, TriggerValue> accumulator)
		{
		}

		// Token: 0x0600176F RID: 5999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600176F")]
		[Address(RVA = "0x692B", Offset = "0x692B", VA = "0x692B")]
		private void UserOnOnUserInfoChangedEvent()
		{
		}

		// Token: 0x06001770 RID: 6000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001770")]
		[Address(RVA = "0x692C", Offset = "0x692C", VA = "0x692C")]
		private void UserOnUserLevelChangedEvent()
		{
		}

		// Token: 0x06001771 RID: 6001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001771")]
		[Address(RVA = "0x692D", Offset = "0x692D", VA = "0x692D")]
		private void CurrentIsleChangedEvent(ulong prevOwnerId)
		{
		}

		// Token: 0x06001772 RID: 6002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001772")]
		[Address(RVA = "0x692E", Offset = "0x692E", VA = "0x692E")]
		private void OnChangeWindows(int visibleFullscreenWndCount)
		{
		}

		// Token: 0x06001773 RID: 6003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001773")]
		[Address(RVA = "0x692F", Offset = "0x692F", VA = "0x692F")]
		private void NotifyUserGoNewLevel()
		{
		}

		// Token: 0x06001774 RID: 6004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001774")]
		[Address(RVA = "0x6930", Offset = "0x6930", VA = "0x6930")]
		public void GetUserLevelReward()
		{
		}

		// Token: 0x06001775 RID: 6005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001775")]
		[Address(RVA = "0x6931", Offset = "0x6931", VA = "0x6931")]
		private void HandleGetUserLevelReward(OpToken<IMessage, object> op)
		{
		}
	}
}
