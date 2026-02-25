using System;
using Core.Data;
using Gameplay.Chat;
using Gameplay.Chat.Model;
using Gameplay.Chat.Model.Data;
using Gameplay.Duel.View;
using Gameplay.World.Model;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Duel.Controller
{
	// Token: 0x02000867 RID: 2151
	[Token(Token = "0x2000867")]
	public class DuelEnterPointViewMediator : AbstractViewMediator<ChatModel, ChatEvents, DuelController, DuelButtonOnMainScreen>
	{
		// Token: 0x06003294 RID: 12948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003294")]
		[Address(RVA = "0x82E9", Offset = "0x82E9", VA = "0x82E9")]
		public DuelEnterPointViewMediator(ChatModel model, ChatEvents events, DuelController controller, WorldModel worldModel)
		{
		}

		// Token: 0x170009F6 RID: 2550
		// (get) Token: 0x06003295 RID: 12949 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170009F6")]
		private UserData CurrentUser
		{
			[Token(Token = "0x6003295")]
			[Address(RVA = "0x82EA", Offset = "0x82EA", VA = "0x82EA")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009F7 RID: 2551
		// (set) Token: 0x06003296 RID: 12950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009F7")]
		public override DuelButtonOnMainScreen View
		{
			[Token(Token = "0x6003296")]
			[Address(RVA = "0x82EB", Offset = "0x82EB", VA = "0x82EB", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x170009F8 RID: 2552
		// (set) Token: 0x06003297 RID: 12951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009F8")]
		public override ChatEvents Events
		{
			[Token(Token = "0x6003297")]
			[Address(RVA = "0x82EC", Offset = "0x82EC", VA = "0x82EC", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06003298 RID: 12952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003298")]
		[Address(RVA = "0x82ED", Offset = "0x82ED", VA = "0x82ED")]
		private void CurrentRoomChangedEventHandler()
		{
		}

		// Token: 0x06003299 RID: 12953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003299")]
		[Address(RVA = "0x82EE", Offset = "0x82EE", VA = "0x82EE")]
		private void ValidateDuelButton()
		{
		}

		// Token: 0x0600329A RID: 12954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600329A")]
		[Address(RVA = "0x82EF", Offset = "0x82EF", VA = "0x82EF")]
		private void UserUpdateEventHandler(ChatVisitorData visitor)
		{
		}

		// Token: 0x0600329B RID: 12955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600329B")]
		[Address(RVA = "0x82F0", Offset = "0x82F0", VA = "0x82F0")]
		private void DuelButtonClickedEventHandler()
		{
		}

		// Token: 0x0600329C RID: 12956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600329C")]
		[Address(RVA = "0x82F1", Offset = "0x82F1", VA = "0x82F1", Slot = "14")]
		public override void Dispose()
		{
		}

		// Token: 0x04001BAD RID: 7085
		[Token(Token = "0x4001BAD")]
		[FieldOffset(Offset = "0x18")]
		private WorldModel _worldModel;
	}
}
