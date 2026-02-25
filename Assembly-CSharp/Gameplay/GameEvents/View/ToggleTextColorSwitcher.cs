using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.GameEvents.View
{
	// Token: 0x02000781 RID: 1921
	[Token(Token = "0x2000781")]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(Toggle))]
	public class ToggleTextColorSwitcher : MonoBehaviour
	{
		// Token: 0x06002DBA RID: 11706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DBA")]
		[Address(RVA = "0x7E38", Offset = "0x7E38", VA = "0x7E38")]
		private void Start()
		{
		}

		// Token: 0x06002DBB RID: 11707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DBB")]
		[Address(RVA = "0x7E39", Offset = "0x7E39", VA = "0x7E39")]
		private void OnEnable()
		{
		}

		// Token: 0x06002DBC RID: 11708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DBC")]
		[Address(RVA = "0x7E3A", Offset = "0x7E3A", VA = "0x7E3A")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002DBD RID: 11709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DBD")]
		[Address(RVA = "0x7E3B", Offset = "0x7E3B", VA = "0x7E3B")]
		private void OnValueChanged(bool value)
		{
		}

		// Token: 0x06002DBE RID: 11710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DBE")]
		[Address(RVA = "0x7E3C", Offset = "0x7E3C", VA = "0x7E3C")]
		public ToggleTextColorSwitcher()
		{
		}

		// Token: 0x04001918 RID: 6424
		[Token(Token = "0x4001918")]
		[FieldOffset(Offset = "0x10")]
		private Toggle _toggle;

		// Token: 0x04001919 RID: 6425
		[Token(Token = "0x4001919")]
		[FieldOffset(Offset = "0x14")]
		private TextMeshProUGUI _label;

		// Token: 0x0400191A RID: 6426
		[Token(Token = "0x400191A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Color _isOnColor;

		// Token: 0x0400191B RID: 6427
		[Token(Token = "0x400191B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color _isOffColor;
	}
}
