using System;
using System.Collections.Generic;
using CloudsFly.Movement;
using Gameplay.Isles.Base;
using Il2CppDummyDll;
using UnityEngine;

namespace CloudsFly
{
	// Token: 0x020012EE RID: 4846
	[Token(Token = "0x20012EE")]
	public interface IIsleWorldObjectEngine
	{
		// Token: 0x06007359 RID: 29529
		[Token(Token = "0x6007359")]
		Vector3 GetIslePosition(IIsle isle);

		// Token: 0x0600735A RID: 29530
		[Token(Token = "0x600735A")]
		void SetIsland(IIsle isle, Vector3 referencePos, Vector3 pos);

		// Token: 0x0600735B RID: 29531
		[Token(Token = "0x600735B")]
		void MoveToIsland(IIsle isle, WorldMovementTypes type, Action callback);

		// Token: 0x0600735C RID: 29532
		[Token(Token = "0x600735C")]
		void MoveVertically(bool isUp, Action callback);

		// Token: 0x0600735D RID: 29533
		[Token(Token = "0x600735D")]
		void ClearViewedIsles(List<IIsle> validIsles);

		// Token: 0x0600735E RID: 29534
		[Token(Token = "0x600735E")]
		void Clear();

		// Token: 0x0600735F RID: 29535
		[Token(Token = "0x600735F")]
		void CancelCurrentMovement();

		// Token: 0x1700174F RID: 5967
		// (get) Token: 0x06007360 RID: 29536
		[Token(Token = "0x1700174F")]
		Dictionary<ulong, BaseIsleWorldObject> CurrentIsles { [Token(Token = "0x6007360")] get; }
	}
}
