using System;
using AssetContent.Loaders;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Inventory.View.Info
{
	// Token: 0x0200066B RID: 1643
	[Token(Token = "0x200066B")]
	public class ArtifactInfoPropertyItemView : MonoBehaviour
	{
		// Token: 0x1700078D RID: 1933
		// (set) Token: 0x060027E8 RID: 10216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700078D")]
		public bool IsBgLight
		{
			[Token(Token = "0x60027E8")]
			[Address(RVA = "0x790E", Offset = "0x790E", VA = "0x790E")]
			set
			{
			}
		}

		// Token: 0x1700078E RID: 1934
		// (set) Token: 0x060027E9 RID: 10217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700078E")]
		public string Title
		{
			[Token(Token = "0x60027E9")]
			[Address(RVA = "0x790F", Offset = "0x790F", VA = "0x790F")]
			set
			{
			}
		}

		// Token: 0x1700078F RID: 1935
		// (set) Token: 0x060027EA RID: 10218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700078F")]
		public string Value
		{
			[Token(Token = "0x60027EA")]
			[Address(RVA = "0x7910", Offset = "0x7910", VA = "0x7910")]
			set
			{
			}
		}

		// Token: 0x17000790 RID: 1936
		// (set) Token: 0x060027EB RID: 10219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000790")]
		public string IconPath
		{
			[Token(Token = "0x60027EB")]
			[Address(RVA = "0x7911", Offset = "0x7911", VA = "0x7911")]
			set
			{
			}
		}

		// Token: 0x060027EC RID: 10220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027EC")]
		[Address(RVA = "0x7912", Offset = "0x7912", VA = "0x7912")]
		public ArtifactInfoPropertyItemView()
		{
		}

		// Token: 0x040015E3 RID: 5603
		[Token(Token = "0x40015E3")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private RawImage _bgImage;

		// Token: 0x040015E4 RID: 5604
		[Token(Token = "0x40015E4")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _titleLabel;

		// Token: 0x040015E5 RID: 5605
		[Token(Token = "0x40015E5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _valueLabel;

		// Token: 0x040015E6 RID: 5606
		[Token(Token = "0x40015E6")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private GameRawImageLoader _iconLoader;

		// Token: 0x040015E7 RID: 5607
		[Token(Token = "0x40015E7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Texture _bgLightTexture;

		// Token: 0x040015E8 RID: 5608
		[Token(Token = "0x40015E8")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Texture _bgDarkTexture;

		// Token: 0x040015E9 RID: 5609
		[Token(Token = "0x40015E9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Vector2 _valueLabelSizeWithoutIcon;

		// Token: 0x040015EA RID: 5610
		[Token(Token = "0x40015EA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Vector2 _valueLabelSizeWithIcon;
	}
}
