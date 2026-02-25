using System;
using AssetContent;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.UserInfo.View
{
	// Token: 0x020003FE RID: 1022
	[Token(Token = "0x20003FE")]
	public class TitleIconValueBackground : MonoBehaviour
	{
		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06001804 RID: 6148 RVA: 0x00005658 File Offset: 0x00003858
		// (set) Token: 0x06001805 RID: 6149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000431")]
		public bool Enabled
		{
			[Token(Token = "0x6001804")]
			[Address(RVA = "0x69BF", Offset = "0x69BF", VA = "0x69BF")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001805")]
			[Address(RVA = "0x19D5", Offset = "0x19D5", VA = "0x19D5")]
			set
			{
			}
		}

		// Token: 0x06001806 RID: 6150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001806")]
		[Address(RVA = "0x69C0", Offset = "0x69C0", VA = "0x69C0")]
		private void HandleEnabledChanged()
		{
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06001807 RID: 6151 RVA: 0x00005670 File Offset: 0x00003870
		// (set) Token: 0x06001808 RID: 6152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000432")]
		public int Index
		{
			[Token(Token = "0x6001807")]
			[Address(RVA = "0x69C1", Offset = "0x69C1", VA = "0x69C1")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001808")]
			[Address(RVA = "0x1C69", Offset = "0x1C69", VA = "0x1C69")]
			set
			{
			}
		}

		// Token: 0x06001809 RID: 6153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001809")]
		[Address(RVA = "0x1C6B", Offset = "0x1C6B", VA = "0x1C6B")]
		public void SetTitle(string value)
		{
		}

		// Token: 0x0600180A RID: 6154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600180A")]
		[Address(RVA = "0x1C6D", Offset = "0x1C6D", VA = "0x1C6D")]
		public void SetIconAssetId(string assetId)
		{
		}

		// Token: 0x0600180B RID: 6155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600180B")]
		[Address(RVA = "0x69C2", Offset = "0x69C2", VA = "0x69C2", Slot = "4")]
		public virtual void SetValue(long value)
		{
		}

		// Token: 0x0600180C RID: 6156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600180C")]
		[Address(RVA = "0x69C3", Offset = "0x69C3", VA = "0x69C3", Slot = "5")]
		public virtual void SetTextValue(string value)
		{
		}

		// Token: 0x0600180D RID: 6157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600180D")]
		[Address(RVA = "0x69C4", Offset = "0x69C4", VA = "0x69C4")]
		public TitleIconValueBackground()
		{
		}

		// Token: 0x04000CBF RID: 3263
		[Token(Token = "0x4000CBF")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		protected Sprite _backgundDark;

		// Token: 0x04000CC0 RID: 3264
		[Token(Token = "0x4000CC0")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		protected Sprite _backgundLight;

		// Token: 0x04000CC1 RID: 3265
		[Token(Token = "0x4000CC1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected Image _backgroudImage;

		// Token: 0x04000CC2 RID: 3266
		[Token(Token = "0x4000CC2")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		protected TextMeshProUGUI _titleField;

		// Token: 0x04000CC3 RID: 3267
		[Token(Token = "0x4000CC3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected TextMeshProUGUI _valueField;

		// Token: 0x04000CC4 RID: 3268
		[Token(Token = "0x4000CC4")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		protected GameRawImage _icon;

		// Token: 0x04000CC5 RID: 3269
		[Token(Token = "0x4000CC5")]
		[FieldOffset(Offset = "0x28")]
		private int _index;

		// Token: 0x04000CC6 RID: 3270
		[Token(Token = "0x4000CC6")]
		[FieldOffset(Offset = "0x2C")]
		private bool _enabled;

		// Token: 0x04000CC7 RID: 3271
		[Token(Token = "0x4000CC7")]
		[FieldOffset(Offset = "0x30")]
		protected long _value;
	}
}
