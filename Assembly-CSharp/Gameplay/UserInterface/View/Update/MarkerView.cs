using System;
using DG.Tweening;
using Il2CppDummyDll;
using UI;

namespace Gameplay.UserInterface.View.Update
{
	// Token: 0x020003D0 RID: 976
	[Token(Token = "0x20003D0")]
	public class MarkerView : MonoBehaviourWithStates<RecommendedAppUpdateViewState>
	{
		// Token: 0x060016E3 RID: 5859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016E3")]
		[Address(RVA = "0x68A2", Offset = "0x68A2", VA = "0x68A2")]
		private void OnDestroy()
		{
		}

		// Token: 0x060016E4 RID: 5860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016E4")]
		[Address(RVA = "0x68A3", Offset = "0x68A3", VA = "0x68A3", Slot = "4")]
		protected override void HandleCurrentStateChanged(RecommendedAppUpdateViewState fromState, RecommendedAppUpdateViewState toState)
		{
		}

		// Token: 0x060016E5 RID: 5861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016E5")]
		[Address(RVA = "0x68A4", Offset = "0x68A4", VA = "0x68A4")]
		public MarkerView()
		{
		}

		// Token: 0x04000C20 RID: 3104
		[Token(Token = "0x4000C20")]
		[FieldOffset(Offset = "0x1C")]
		private Tween _scaleTween;
	}
}
