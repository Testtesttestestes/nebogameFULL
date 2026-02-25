using System;
using Gameplay.Sound.Model;
using Gameplay.World.Events;
using Gameplay.World.Model;
using Gameplay.World.View;
using Il2CppDummyDll;

namespace Gameplay.World.Controller
{
	// Token: 0x0200037F RID: 895
	[Token(Token = "0x200037F")]
	public class WorldUserLevelViewMediator : AbstractWorldViewMediator
	{
		// Token: 0x060014DA RID: 5338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014DA")]
		[Address(RVA = "0x669C", Offset = "0x669C", VA = "0x669C")]
		public WorldUserLevelViewMediator(WorldModel model, WorldControllerEvents events, WorldController controller)
		{
		}

		// Token: 0x17000368 RID: 872
		// (set) Token: 0x060014DB RID: 5339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000368")]
		public override WorldControllerEvents Events
		{
			[Token(Token = "0x60014DB")]
			[Address(RVA = "0x669D", Offset = "0x669D", VA = "0x669D", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x060014DC RID: 5340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014DC")]
		[Address(RVA = "0x669E", Offset = "0x669E", VA = "0x669E")]
		private void CurrentIsleChangedEventHandler(ulong prevOwnerId)
		{
		}

		// Token: 0x17000369 RID: 873
		// (set) Token: 0x060014DD RID: 5341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000369")]
		public override WorldView View
		{
			[Token(Token = "0x60014DD")]
			[Address(RVA = "0x669F", Offset = "0x669F", VA = "0x669F", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x060014DE RID: 5342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014DE")]
		[Address(RVA = "0x66A0", Offset = "0x66A0", VA = "0x66A0", Slot = "21")]
		public override void Clear()
		{
		}

		// Token: 0x060014DF RID: 5343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014DF")]
		[Address(RVA = "0x66A1", Offset = "0x66A1", VA = "0x66A1", Slot = "22")]
		protected override void StartMovement()
		{
		}

		// Token: 0x060014E0 RID: 5344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014E0")]
		[Address(RVA = "0x66A2", Offset = "0x66A2", VA = "0x66A2", Slot = "23")]
		protected override void CompleteMovement()
		{
		}

		// Token: 0x060014E1 RID: 5345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014E1")]
		[Address(RVA = "0x66A3", Offset = "0x66A3", VA = "0x66A3", Slot = "24")]
		protected virtual void StartMusic(PlayLists playLists)
		{
		}

		// Token: 0x060014E2 RID: 5346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014E2")]
		[Address(RVA = "0x66A4", Offset = "0x66A4", VA = "0x66A4", Slot = "14")]
		public override void Dispose()
		{
		}
	}
}
