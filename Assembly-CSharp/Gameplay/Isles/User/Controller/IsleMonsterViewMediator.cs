using System;
using Core;
using Gameplay.Isles.User.Events;
using Gameplay.Isles.User.Model;
using Gameplay.Isles.User.View.Monster;
using Gameplay.World.Events;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Isles.User.Controller
{
	// Token: 0x02000D3A RID: 3386
	[Token(Token = "0x2000D3A")]
	public class IsleMonsterViewMediator : AbstractViewMediator<UserIsleModel, UserIsleEvents, UserIsleController, IsleMonsterView>
	{
		// Token: 0x060052D6 RID: 21206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052D6")]
		[Address(RVA = "0xA0AC", Offset = "0xA0AC", VA = "0xA0AC", Slot = "14")]
		public override void Dispose()
		{
		}

		// Token: 0x060052D7 RID: 21207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052D7")]
		[Address(RVA = "0xA0AD", Offset = "0xA0AD", VA = "0xA0AD")]
		public IsleMonsterViewMediator(UserIsleModel model, UserIsleEvents events, UserIsleController controller)
		{
		}

		// Token: 0x170010E3 RID: 4323
		// (set) Token: 0x060052D8 RID: 21208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010E3")]
		public override UserIsleEvents Events
		{
			[Token(Token = "0x60052D8")]
			[Address(RVA = "0xA0AE", Offset = "0xA0AE", VA = "0xA0AE", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x060052D9 RID: 21209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052D9")]
		[Address(RVA = "0xA0AF", Offset = "0xA0AF", VA = "0xA0AF")]
		private void HandleDisposeEvent()
		{
		}

		// Token: 0x060052DA RID: 21210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052DA")]
		[Address(RVA = "0xA0B0", Offset = "0xA0B0", VA = "0xA0B0")]
		private void IsCurrentChangedEvent()
		{
		}

		// Token: 0x060052DB RID: 21211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052DB")]
		[Address(RVA = "0xA0B1", Offset = "0xA0B1", VA = "0xA0B1")]
		private void MonsterChangedEvent(WorldControllerEvents.MonsterChangeReason reason)
		{
		}

		// Token: 0x060052DC RID: 21212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052DC")]
		[Address(RVA = "0xA0B2", Offset = "0xA0B2", VA = "0xA0B2")]
		private void UpdateMonster()
		{
		}

		// Token: 0x170010E4 RID: 4324
		// (set) Token: 0x060052DD RID: 21213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010E4")]
		public override IsleMonsterView View
		{
			[Token(Token = "0x60052DD")]
			[Address(RVA = "0xA0B3", Offset = "0xA0B3", VA = "0xA0B3", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x060052DE RID: 21214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052DE")]
		[Address(RVA = "0xA0B4", Offset = "0xA0B4", VA = "0xA0B4")]
		private void ReadyEventHandler(IAsyncLoadableContent content)
		{
		}

		// Token: 0x060052DF RID: 21215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052DF")]
		[Address(RVA = "0xA0B5", Offset = "0xA0B5", VA = "0xA0B5")]
		private void OnMonsterClick()
		{
		}
	}
}
