using System;
using Gameplay.World.Events;
using Gameplay.World.Model;
using Gameplay.World.View;
using Il2CppDummyDll;

namespace Gameplay.World.Controller
{
	// Token: 0x0200037C RID: 892
	[Token(Token = "0x200037C")]
	public class WorldClanLevelViewMediator : AbstractWorldViewMediator
	{
		// Token: 0x060014A8 RID: 5288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014A8")]
		[Address(RVA = "0x666A", Offset = "0x666A", VA = "0x666A")]
		public WorldClanLevelViewMediator(WorldModel model, WorldControllerEvents events, WorldController controller)
		{
		}

		// Token: 0x17000366 RID: 870
		// (set) Token: 0x060014A9 RID: 5289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000366")]
		public override WorldControllerEvents Events
		{
			[Token(Token = "0x60014A9")]
			[Address(RVA = "0x666B", Offset = "0x666B", VA = "0x666B", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x17000367 RID: 871
		// (set) Token: 0x060014AA RID: 5290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000367")]
		public override WorldView View
		{
			[Token(Token = "0x60014AA")]
			[Address(RVA = "0x666C", Offset = "0x666C", VA = "0x666C", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x060014AB RID: 5291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014AB")]
		[Address(RVA = "0x666D", Offset = "0x666D", VA = "0x666D", Slot = "21")]
		public override void Clear()
		{
		}

		// Token: 0x060014AC RID: 5292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014AC")]
		[Address(RVA = "0x666E", Offset = "0x666E", VA = "0x666E", Slot = "22")]
		protected override void StartMovement()
		{
		}

		// Token: 0x060014AD RID: 5293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014AD")]
		[Address(RVA = "0x666F", Offset = "0x666F", VA = "0x666F", Slot = "23")]
		protected override void CompleteMovement()
		{
		}

		// Token: 0x060014AE RID: 5294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014AE")]
		[Address(RVA = "0x6670", Offset = "0x6670", VA = "0x6670")]
		private void CurrentIsleChangedEvent(ulong prevOwnerId)
		{
		}

		// Token: 0x060014AF RID: 5295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014AF")]
		[Address(RVA = "0x6671", Offset = "0x6671", VA = "0x6671", Slot = "14")]
		public override void Dispose()
		{
		}
	}
}
