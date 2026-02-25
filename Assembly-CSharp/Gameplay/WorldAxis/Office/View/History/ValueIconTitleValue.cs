using System;
using AssetContent;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Gameplay.WorldAxis.Office.View.History
{
	// Token: 0x02000319 RID: 793
	[Token(Token = "0x2000319")]
	public class ValueIconTitleValue : MonoBehaviour
	{
		// Token: 0x0600124F RID: 4687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600124F")]
		[Address(RVA = "0x6449", Offset = "0x6449", VA = "0x6449")]
		public void SetTitle(string title)
		{
		}

		// Token: 0x06001250 RID: 4688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001250")]
		[Address(RVA = "0x644A", Offset = "0x644A", VA = "0x644A")]
		public void SetIcon(string iconAssetId)
		{
		}

		// Token: 0x06001251 RID: 4689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001251")]
		[Address(RVA = "0x644B", Offset = "0x644B", VA = "0x644B")]
		public void UpdateValues(long value1, long value2)
		{
		}

		// Token: 0x06001252 RID: 4690 RVA: 0x00004968 File Offset: 0x00002B68
		[Token(Token = "0x6001252")]
		[Address(RVA = "0x644C", Offset = "0x644C", VA = "0x644C")]
		private Color32 ColorByValue(long value)
		{
			return default(Color32);
		}

		// Token: 0x06001253 RID: 4691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001253")]
		[Address(RVA = "0x644D", Offset = "0x644D", VA = "0x644D")]
		public void Init(string title, long value1, long value2)
		{
		}

		// Token: 0x06001254 RID: 4692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001254")]
		[Address(RVA = "0x644E", Offset = "0x644E", VA = "0x644E")]
		public ValueIconTitleValue()
		{
		}

		// Token: 0x040009C4 RID: 2500
		[Token(Token = "0x40009C4")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _value1;

		// Token: 0x040009C5 RID: 2501
		[Token(Token = "0x40009C5")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _value2;

		// Token: 0x040009C6 RID: 2502
		[Token(Token = "0x40009C6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x040009C7 RID: 2503
		[Token(Token = "0x40009C7")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private GameImage _icon;
	}
}
