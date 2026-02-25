using System;
using System.Collections.Generic;
using CloudsFly.Movement;
using Gameplay.Isles.Base;
using Il2CppDummyDll;
using UnityEngine;
using Utils.Cache;

namespace CloudsFly
{
	// Token: 0x020012EF RID: 4847
	[Token(Token = "0x20012EF")]
	public abstract class BaseIsleWorldObjectEngine<T> : WorldObjectEngine<T>, IIsleWorldObjectEngine where T : BaseIsleWorldObjectEngineArgs
	{
		// Token: 0x17001750 RID: 5968
		// (get) Token: 0x06007361 RID: 29537 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001750")]
		public Dictionary<ulong, BaseIsleWorldObject> CurrentIsles
		{
			[Token(Token = "0x6007361")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007362 RID: 29538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007362")]
		protected override void OnInit(T args)
		{
		}

		// Token: 0x06007363 RID: 29539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007363")]
		protected override void OnLateUpdate()
		{
		}

		// Token: 0x06007364 RID: 29540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007364")]
		protected override void OnResetPositions(Vector3 deltaPos)
		{
		}

		// Token: 0x06007365 RID: 29541 RVA: 0x00014BC8 File Offset: 0x00012DC8
		[Token(Token = "0x6007365")]
		public Vector3 GetIslePosition(IIsle isle)
		{
			return default(Vector3);
		}

		// Token: 0x06007366 RID: 29542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007366")]
		public void SetIsland(IIsle isle, Vector3 referencePos, Vector3 pos)
		{
		}

		// Token: 0x06007367 RID: 29543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007367")]
		public void MoveToIsland(IIsle isle, WorldMovementTypes type, Action callback)
		{
		}

		// Token: 0x06007368 RID: 29544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007368")]
		public void MoveVertically(bool isUp, Action callback)
		{
		}

		// Token: 0x06007369 RID: 29545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007369")]
		private void OnStartMovement()
		{
		}

		// Token: 0x0600736A RID: 29546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600736A")]
		private void OnCompleteMovement(BaseIsleWorldObject baseIsleWorldObject, Action callback)
		{
		}

		// Token: 0x0600736B RID: 29547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600736B")]
		public void ClearViewedIsles(List<IIsle> validIsles)
		{
		}

		// Token: 0x0600736C RID: 29548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600736C")]
		public void Clear()
		{
		}

		// Token: 0x0600736D RID: 29549 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600736D")]
		private AbstractWorldMovement GetMovementByType(WorldMovementTypes type)
		{
			return null;
		}

		// Token: 0x0600736E RID: 29550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600736E")]
		public void CancelCurrentMovement()
		{
		}

		// Token: 0x0600736F RID: 29551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600736F")]
		private void OnReleaseIsland(BaseIsleWorldObject baseIsleWorldObject)
		{
		}

		// Token: 0x06007370 RID: 29552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007370")]
		protected BaseIsleWorldObjectEngine()
		{
		}

		// Token: 0x04003C5F RID: 15455
		[Token(Token = "0x4003C5F")]
		private const float VERTICAL_ALTITUDE = 500f;

		// Token: 0x04003C60 RID: 15456
		[Token(Token = "0x4003C60")]
		[FieldOffset(Offset = "0x0")]
		private GameObjectPool<BaseIsleWorldObject> _islandPool;

		// Token: 0x04003C61 RID: 15457
		[Token(Token = "0x4003C61")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<ulong, BaseIsleWorldObject> _currentIsles;

		// Token: 0x04003C62 RID: 15458
		[Token(Token = "0x4003C62")]
		[FieldOffset(Offset = "0x0")]
		private Transform _islandCloudContainer;

		// Token: 0x04003C63 RID: 15459
		[Token(Token = "0x4003C63")]
		[FieldOffset(Offset = "0x0")]
		private BaseIsleWorldObject _islandPrefab;

		// Token: 0x04003C64 RID: 15460
		[Token(Token = "0x4003C64")]
		[FieldOffset(Offset = "0x0")]
		private AbstractWorldMovement _currentMovement;
	}
}
