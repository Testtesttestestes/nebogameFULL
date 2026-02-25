using System;
using CloudsFly;
using Gameplay.Isles.Base;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.World.Model.View.IslandEngineActions
{
	// Token: 0x02000373 RID: 883
	[Token(Token = "0x2000373")]
	public class SetIsleEngineAction : BaseIsleEngineAction
	{
		// Token: 0x06001491 RID: 5265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001491")]
		[Address(RVA = "0x665B", Offset = "0x665B", VA = "0x665B")]
		public SetIsleEngineAction(IIsleWorldObjectEngine engine, IIsle isle, IIsle parentIsle, Vector3 position)
		{
		}

		// Token: 0x06001492 RID: 5266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001492")]
		[Address(RVA = "0x665C", Offset = "0x665C", VA = "0x665C", Slot = "5")]
		public override void Invoke(Action<BaseIsleEngineAction> endCallback)
		{
		}

		// Token: 0x06001493 RID: 5267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001493")]
		[Address(RVA = "0x665D", Offset = "0x665D", VA = "0x665D", Slot = "6")]
		public override void Cancel()
		{
		}

		// Token: 0x06001494 RID: 5268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001494")]
		[Address(RVA = "0x665E", Offset = "0x665E", VA = "0x665E", Slot = "7")]
		public override void Dispose()
		{
		}

		// Token: 0x04000AF1 RID: 2801
		[Token(Token = "0x4000AF1")]
		[FieldOffset(Offset = "0xC")]
		private IIsle _isle;

		// Token: 0x04000AF2 RID: 2802
		[Token(Token = "0x4000AF2")]
		[FieldOffset(Offset = "0x10")]
		private IIsle _parentIsle;

		// Token: 0x04000AF3 RID: 2803
		[Token(Token = "0x4000AF3")]
		[FieldOffset(Offset = "0x14")]
		private Vector3 _position;
	}
}
