using System;
using Gameplay.World.Events;
using Gameplay.World.Model;
using Gameplay.World.View;
using Il2CppDummyDll;

namespace Gameplay.World.Controller
{
	// Token: 0x0200037B RID: 891
	[Token(Token = "0x200037B")]
	public class WorldAxisLevelViewMediator : AbstractWorldViewMediator
	{
		// Token: 0x060014A3 RID: 5283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014A3")]
		[Address(RVA = "0x6665", Offset = "0x6665", VA = "0x6665")]
		public WorldAxisLevelViewMediator(WorldModel model, WorldControllerEvents events, WorldController controller)
		{
		}

		// Token: 0x17000365 RID: 869
		// (set) Token: 0x060014A4 RID: 5284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000365")]
		public override WorldView View
		{
			[Token(Token = "0x60014A4")]
			[Address(RVA = "0x6666", Offset = "0x6666", VA = "0x6666", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x060014A5 RID: 5285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014A5")]
		[Address(RVA = "0x6667", Offset = "0x6667", VA = "0x6667", Slot = "21")]
		public override void Clear()
		{
		}

		// Token: 0x060014A6 RID: 5286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014A6")]
		[Address(RVA = "0x6668", Offset = "0x6668", VA = "0x6668", Slot = "22")]
		protected override void StartMovement()
		{
		}

		// Token: 0x060014A7 RID: 5287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014A7")]
		[Address(RVA = "0x6669", Offset = "0x6669", VA = "0x6669", Slot = "23")]
		protected override void CompleteMovement()
		{
		}
	}
}
