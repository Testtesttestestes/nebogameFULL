using System;
using Il2CppDummyDll;
using UI;
using UnityEngine;

namespace Gameplay.TutorialV2.View
{
	// Token: 0x0200042B RID: 1067
	[Token(Token = "0x200042B")]
	public class TutorialAdditionalView : MonoBehaviour
	{
		// Token: 0x0600193D RID: 6461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600193D")]
		[Address(RVA = "0x6ADC", Offset = "0x6ADC", VA = "0x6ADC")]
		private void Awake()
		{
		}

		// Token: 0x0600193E RID: 6462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600193E")]
		[Address(RVA = "0x6ADD", Offset = "0x6ADD", VA = "0x6ADD")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600193F RID: 6463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600193F")]
		[Address(RVA = "0x6ADE", Offset = "0x6ADE", VA = "0x6ADE")]
		private void ToggleValueChangedEventHandler(ToggleButton btn)
		{
		}

		// Token: 0x06001940 RID: 6464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001940")]
		[Address(RVA = "0x6ADF", Offset = "0x6ADF", VA = "0x6ADF")]
		public TutorialAdditionalView()
		{
		}

		// Token: 0x04000D59 RID: 3417
		[Token(Token = "0x4000D59")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private ToggleButton _muteToggle;
	}
}
