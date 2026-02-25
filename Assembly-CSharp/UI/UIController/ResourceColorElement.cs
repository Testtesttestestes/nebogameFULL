using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.UIController
{
	// Token: 0x02000131 RID: 305
	[Token(Token = "0x2000131")]
	[Serializable]
	public class ResourceColorElement
	{
		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000947 RID: 2375 RVA: 0x000036F0 File Offset: 0x000018F0
		[Token(Token = "0x17000134")]
		public ResourceBarColor ResourceBarColor
		{
			[Token(Token = "0x6000947")]
			[Address(RVA = "0x5CC1", Offset = "0x5CC1", VA = "0x5CC1")]
			get
			{
				return ResourceBarColor.Default;
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000948 RID: 2376 RVA: 0x00003708 File Offset: 0x00001908
		[Token(Token = "0x17000135")]
		public Color Color
		{
			[Token(Token = "0x6000948")]
			[Address(RVA = "0x5CC2", Offset = "0x5CC2", VA = "0x5CC2")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000949 RID: 2377 RVA: 0x00003720 File Offset: 0x00001920
		[Token(Token = "0x17000136")]
		public bool ShowCloud
		{
			[Token(Token = "0x6000949")]
			[Address(RVA = "0x5CC3", Offset = "0x5CC3", VA = "0x5CC3")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600094A")]
		[Address(RVA = "0x5CC4", Offset = "0x5CC4", VA = "0x5CC4")]
		public ResourceColorElement()
		{
		}

		// Token: 0x0400036E RID: 878
		[Token(Token = "0x400036E")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		private ResourceBarColor _resourceBarColor;

		// Token: 0x0400036F RID: 879
		[Token(Token = "0x400036F")]
		[FieldOffset(Offset = "0xC")]
		[SerializeField]
		private Color _color;

		// Token: 0x04000370 RID: 880
		[Token(Token = "0x4000370")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private bool _showCloud;
	}
}
