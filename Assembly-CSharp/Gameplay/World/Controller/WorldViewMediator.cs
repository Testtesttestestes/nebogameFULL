using System;
using Gameplay.World.Events;
using Gameplay.World.Model;
using Gameplay.World.View;
using Il2CppDummyDll;
using Protocol.Consts;

namespace Gameplay.World.Controller
{
	// Token: 0x02000382 RID: 898
	[Token(Token = "0x2000382")]
	public class WorldViewMediator : AbstractWorldViewMediator
	{
		// Token: 0x060014E8 RID: 5352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014E8")]
		[Address(RVA = "0x66AA", Offset = "0x66AA", VA = "0x66AA")]
		public WorldViewMediator(WorldModel model, WorldControllerEvents events, WorldController controller)
		{
		}

		// Token: 0x1700036A RID: 874
		// (set) Token: 0x060014E9 RID: 5353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700036A")]
		public override WorldControllerEvents Events
		{
			[Token(Token = "0x60014E9")]
			[Address(RVA = "0x66AB", Offset = "0x66AB", VA = "0x66AB", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x060014EA RID: 5354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014EA")]
		[Address(RVA = "0x66AC", Offset = "0x66AC", VA = "0x66AC")]
		private void RequestIsleInformationEvent(ulong isleId)
		{
		}

		// Token: 0x060014EB RID: 5355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014EB")]
		[Address(RVA = "0x66AD", Offset = "0x66AD", VA = "0x66AD")]
		private void WorldLocationChangedEvent()
		{
		}

		// Token: 0x060014EC RID: 5356 RVA: 0x00005178 File Offset: 0x00003378
		[Token(Token = "0x60014EC")]
		[Address(RVA = "0x66AE", Offset = "0x66AE", VA = "0x66AE")]
		private WorldLevel GetWorldLevelByLocationType(LocationTypes type)
		{
			return WorldLevel.Unknown;
		}

		// Token: 0x1700036B RID: 875
		// (set) Token: 0x060014ED RID: 5357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700036B")]
		public override WorldView View
		{
			[Token(Token = "0x60014ED")]
			[Address(RVA = "0x66AF", Offset = "0x66AF", VA = "0x66AF", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x060014EE RID: 5358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014EE")]
		[Address(RVA = "0x66B0", Offset = "0x66B0", VA = "0x66B0")]
		private void ResetView()
		{
		}

		// Token: 0x060014EF RID: 5359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014EF")]
		[Address(RVA = "0x66B1", Offset = "0x66B1", VA = "0x66B1")]
		private void SetView()
		{
		}

		// Token: 0x060014F0 RID: 5360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014F0")]
		[Address(RVA = "0x66B2", Offset = "0x66B2", VA = "0x66B2", Slot = "21")]
		public override void Clear()
		{
		}

		// Token: 0x060014F1 RID: 5361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014F1")]
		[Address(RVA = "0x66B3", Offset = "0x66B3", VA = "0x66B3", Slot = "22")]
		protected override void StartMovement()
		{
		}

		// Token: 0x060014F2 RID: 5362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014F2")]
		[Address(RVA = "0x66B4", Offset = "0x66B4", VA = "0x66B4", Slot = "23")]
		protected override void CompleteMovement()
		{
		}

		// Token: 0x060014F3 RID: 5363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014F3")]
		[Address(RVA = "0x66B5", Offset = "0x66B5", VA = "0x66B5")]
		private void ViewOnWorldLevelChangedEvent(WorldLevel prevWorldLevel, WorldLevel newWorldLevel)
		{
		}

		// Token: 0x060014F4 RID: 5364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014F4")]
		[Address(RVA = "0x66B6", Offset = "0x66B6", VA = "0x66B6", Slot = "14")]
		public override void Dispose()
		{
		}

		// Token: 0x04000B0D RID: 2829
		[Token(Token = "0x4000B0D")]
		[FieldOffset(Offset = "0x18")]
		private AbstractWorldViewMediator _currentLevelMediator;
	}
}
