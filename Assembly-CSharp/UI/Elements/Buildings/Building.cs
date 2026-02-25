using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Utils;

namespace UI.Elements.Buildings
{
	// Token: 0x02000245 RID: 581
	[Token(Token = "0x2000245")]
	public abstract class Building : MonoBehaviour
	{
		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06000E3D RID: 3645 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000E3E RID: 3646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001E9")]
		protected string MainText
		{
			[Token(Token = "0x6000E3D")]
			[Address(RVA = "0x60CE", Offset = "0x60CE", VA = "0x60CE")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000E3E")]
			[Address(RVA = "0x60CF", Offset = "0x60CF", VA = "0x60CF")]
			set
			{
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06000E3F RID: 3647 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000E40 RID: 3648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001EA")]
		protected string TipText
		{
			[Token(Token = "0x6000E3F")]
			[Address(RVA = "0x60D0", Offset = "0x60D0", VA = "0x60D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000E40")]
			[Address(RVA = "0x60D1", Offset = "0x60D1", VA = "0x60D1")]
			set
			{
			}
		}

		// Token: 0x06000E41 RID: 3649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E41")]
		[Address(RVA = "0x60D2", Offset = "0x60D2", VA = "0x60D2")]
		public void Init(BuildingBaseArgs args)
		{
		}

		// Token: 0x06000E42 RID: 3650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E42")]
		[Address(RVA = "0x60D3", Offset = "0x60D3", VA = "0x60D3")]
		private void OnClick()
		{
		}

		// Token: 0x06000E43 RID: 3651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E43")]
		[Address(RVA = "0x60D4", Offset = "0x60D4", VA = "0x60D4")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000E44 RID: 3652
		[Token(Token = "0x6000E44")]
		protected abstract void OnInit(BuildingBaseArgs args);

		// Token: 0x06000E45 RID: 3653
		[Token(Token = "0x6000E45")]
		protected abstract void OnClose();

		// Token: 0x06000E46 RID: 3654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E46")]
		[Address(RVA = "0x60D5", Offset = "0x60D5", VA = "0x60D5")]
		protected Building()
		{
		}

		// Token: 0x04000716 RID: 1814
		[Token(Token = "0x4000716")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Image _background;

		// Token: 0x04000717 RID: 1815
		[Token(Token = "0x4000717")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _mainText;

		// Token: 0x04000718 RID: 1816
		[Token(Token = "0x4000718")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _tipText;

		// Token: 0x04000719 RID: 1817
		[Token(Token = "0x4000719")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Button _button;

		// Token: 0x0400071A RID: 1818
		[Token(Token = "0x400071A")]
		[FieldOffset(Offset = "0x20")]
		public TypedUnityEvent<Building> onClick;
	}
}
