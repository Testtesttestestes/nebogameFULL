using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Gameplay.Inventory.View
{
	// Token: 0x02000663 RID: 1635
	[Token(Token = "0x2000663")]
	[DisallowMultipleComponent]
	public class NumpadView : MonoBehaviour
	{
		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x060027B6 RID: 10166 RVA: 0x00007998 File Offset: 0x00005B98
		// (set) Token: 0x060027B5 RID: 10165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000787")]
		public int Value
		{
			[Token(Token = "0x60027B6")]
			[Address(RVA = "0x78DC", Offset = "0x78DC", VA = "0x78DC")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60027B5")]
			[Address(RVA = "0x78DB", Offset = "0x78DB", VA = "0x78DB")]
			set
			{
			}
		}

		// Token: 0x060027B7 RID: 10167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027B7")]
		[Address(RVA = "0x78DD", Offset = "0x78DD", VA = "0x78DD")]
		public void SetActive(bool active)
		{
		}

		// Token: 0x060027B8 RID: 10168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027B8")]
		[Address(RVA = "0x78DE", Offset = "0x78DE", VA = "0x78DE")]
		public void OnButtonClick(string value)
		{
		}

		// Token: 0x060027B9 RID: 10169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027B9")]
		[Address(RVA = "0x78DF", Offset = "0x78DF", VA = "0x78DF")]
		private void InputNumber(int value)
		{
		}

		// Token: 0x060027BA RID: 10170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027BA")]
		[Address(RVA = "0x78E0", Offset = "0x78E0", VA = "0x78E0")]
		private void OnOkHandler()
		{
		}

		// Token: 0x060027BB RID: 10171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027BB")]
		[Address(RVA = "0x78E1", Offset = "0x78E1", VA = "0x78E1")]
		private void OnBackspaceHandler()
		{
		}

		// Token: 0x060027BC RID: 10172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027BC")]
		[Address(RVA = "0x78E2", Offset = "0x78E2", VA = "0x78E2")]
		private void Start()
		{
		}

		// Token: 0x060027BD RID: 10173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027BD")]
		[Address(RVA = "0x78E3", Offset = "0x78E3", VA = "0x78E3")]
		private void OnDestroy()
		{
		}

		// Token: 0x060027BE RID: 10174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027BE")]
		[Address(RVA = "0x78E4", Offset = "0x78E4", VA = "0x78E4")]
		private void OnSliderChangedHandler(int value)
		{
		}

		// Token: 0x060027BF RID: 10175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027BF")]
		[Address(RVA = "0x78E5", Offset = "0x78E5", VA = "0x78E5")]
		private void OnArtifactSelectHandler(SplitArtifactView.ArtifactSelection selection)
		{
		}

		// Token: 0x060027C0 RID: 10176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027C0")]
		[Address(RVA = "0x78E6", Offset = "0x78E6", VA = "0x78E6")]
		public NumpadView()
		{
		}

		// Token: 0x040015BC RID: 5564
		[Token(Token = "0x40015BC")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private CanvasGroup _contentCanvasGroup;

		// Token: 0x040015BD RID: 5565
		[Token(Token = "0x40015BD")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameObject _disableBlend;

		// Token: 0x040015BE RID: 5566
		[Token(Token = "0x40015BE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _indicator;

		// Token: 0x040015BF RID: 5567
		[Token(Token = "0x40015BF")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private ConfirmSplitArtifactWindow _confirmSplitArtifactWindow;

		// Token: 0x040015C0 RID: 5568
		[Token(Token = "0x40015C0")]
		[FieldOffset(Offset = "0x20")]
		public Action<SplitArtifactView.ArtifactSelection, int> OnOk;
	}
}
