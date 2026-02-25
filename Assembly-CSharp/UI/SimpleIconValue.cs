using System;
using AssetContent;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace UI
{
	// Token: 0x02000113 RID: 275
	[Token(Token = "0x2000113")]
	public class SimpleIconValue : MonoBehaviour
	{
		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060008B0 RID: 2224 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060008B1 RID: 2225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700011A")]
		public string IconAssetId
		{
			[Token(Token = "0x60008B0")]
			[Address(RVA = "0x5C3F", Offset = "0x5C3F", VA = "0x5C3F")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008B1")]
			[Address(RVA = "0x1AFE", Offset = "0x1AFE", VA = "0x1AFE")]
			set
			{
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x060008B2 RID: 2226 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060008B3 RID: 2227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700011B")]
		public string Value
		{
			[Token(Token = "0x60008B2")]
			[Address(RVA = "0x5C40", Offset = "0x5C40", VA = "0x5C40")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008B3")]
			[Address(RVA = "0x1B00", Offset = "0x1B00", VA = "0x1B00")]
			set
			{
			}
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x5C41", Offset = "0x5C41", VA = "0x5C41", Slot = "4")]
		protected virtual void HandleValueChanged()
		{
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008B5")]
		[Address(RVA = "0x1B02", Offset = "0x1B02", VA = "0x1B02")]
		public void SetColor(in Color value)
		{
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008B6")]
		[Address(RVA = "0x5C42", Offset = "0x5C42", VA = "0x5C42")]
		public SimpleIconValue()
		{
		}

		// Token: 0x04000321 RID: 801
		[Token(Token = "0x4000321")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameRawImage _icon;

		// Token: 0x04000322 RID: 802
		[Token(Token = "0x4000322")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _valueLabel;

		// Token: 0x04000323 RID: 803
		[Token(Token = "0x4000323")]
		[FieldOffset(Offset = "0x18")]
		private string _value;
	}
}
