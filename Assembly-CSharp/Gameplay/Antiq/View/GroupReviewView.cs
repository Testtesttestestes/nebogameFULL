using System;
using AssetContent;
using Il2CppDummyDll;
using TMPro;
using UI;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Antiq.View
{
	// Token: 0x02000D82 RID: 3458
	[Token(Token = "0x2000D82")]
	[AddComponentMenu("Antiq/View/GroupReviewView")]
	internal class GroupReviewView : MonoBehaviour
	{
		// Token: 0x17001136 RID: 4406
		// (get) Token: 0x060054A3 RID: 21667 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001136")]
		public GroupReviewView.Controls ArtifactControl
		{
			[Token(Token = "0x60054A3")]
			[Address(RVA = "0xA251", Offset = "0xA251", VA = "0xA251")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001137 RID: 4407
		// (get) Token: 0x060054A4 RID: 21668 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001137")]
		public GroupReviewView.Controls GroupControls
		{
			[Token(Token = "0x60054A4")]
			[Address(RVA = "0xA252", Offset = "0xA252", VA = "0xA252")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001138 RID: 4408
		// (get) Token: 0x060054A5 RID: 21669 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001138")]
		public GameAssetViewRawImage Image
		{
			[Token(Token = "0x60054A5")]
			[Address(RVA = "0xA253", Offset = "0xA253", VA = "0xA253")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001139 RID: 4409
		// (get) Token: 0x060054A6 RID: 21670 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001139")]
		public RectTransform GroupHeader
		{
			[Token(Token = "0x60054A6")]
			[Address(RVA = "0xA254", Offset = "0xA254", VA = "0xA254")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700113A RID: 4410
		// (get) Token: 0x060054A7 RID: 21671 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700113A")]
		public GroupReviewView.TextControls TextFields
		{
			[Token(Token = "0x60054A7")]
			[Address(RVA = "0xA255", Offset = "0xA255", VA = "0xA255")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700113B RID: 4411
		// (get) Token: 0x060054A8 RID: 21672 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700113B")]
		public Transform CurrentLevelCounter
		{
			[Token(Token = "0x60054A8")]
			[Address(RVA = "0xA256", Offset = "0xA256", VA = "0xA256")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700113C RID: 4412
		// (get) Token: 0x060054A9 RID: 21673 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700113C")]
		public Transform MaxLevelCounter
		{
			[Token(Token = "0x60054A9")]
			[Address(RVA = "0xA257", Offset = "0xA257", VA = "0xA257")]
			get
			{
				return null;
			}
		}

		// Token: 0x060054AA RID: 21674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054AA")]
		[Address(RVA = "0xA258", Offset = "0xA258", VA = "0xA258")]
		public void SetEnableGrayscale(bool value)
		{
		}

		// Token: 0x060054AB RID: 21675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054AB")]
		[Address(RVA = "0xA259", Offset = "0xA259", VA = "0xA259")]
		public void ClearEffects()
		{
		}

		// Token: 0x060054AC RID: 21676 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60054AC")]
		[Address(RVA = "0x1D27", Offset = "0x1D27", VA = "0x1D27")]
		public EffectView CreateEffectView()
		{
			return null;
		}

		// Token: 0x060054AD RID: 21677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054AD")]
		[Address(RVA = "0xA25A", Offset = "0xA25A", VA = "0xA25A")]
		public GroupReviewView()
		{
		}

		// Token: 0x04002DD4 RID: 11732
		[Token(Token = "0x4002DD4")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GroupReviewView.Controls _groupControls;

		// Token: 0x04002DD5 RID: 11733
		[Token(Token = "0x4002DD5")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GroupReviewView.Controls _artifactControl;

		// Token: 0x04002DD6 RID: 11734
		[Token(Token = "0x4002DD6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GroupReviewView.TextControls _textControls;

		// Token: 0x04002DD7 RID: 11735
		[Token(Token = "0x4002DD7")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private EffectView _effectPrefab;

		// Token: 0x04002DD8 RID: 11736
		[Token(Token = "0x4002DD8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _maxLevelCounter;

		// Token: 0x04002DD9 RID: 11737
		[Token(Token = "0x4002DD9")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Transform _currentLevelCounter;

		// Token: 0x04002DDA RID: 11738
		[Token(Token = "0x4002DDA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ImageWithGrayscale[] _grayscales;

		// Token: 0x04002DDB RID: 11739
		[Token(Token = "0x4002DDB")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private GameAssetViewRawImage _image;

		// Token: 0x04002DDC RID: 11740
		[Token(Token = "0x4002DDC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _effectsContainer;

		// Token: 0x04002DDD RID: 11741
		[Token(Token = "0x4002DDD")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private RectTransform _groupHeader;

		// Token: 0x02000D83 RID: 3459
		[Token(Token = "0x2000D83")]
		[Serializable]
		internal class Controls
		{
			// Token: 0x1700113D RID: 4413
			// (get) Token: 0x060054AE RID: 21678 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700113D")]
			public Button Back
			{
				[Token(Token = "0x60054AE")]
				[Address(RVA = "0xA25B", Offset = "0xA25B", VA = "0xA25B")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700113E RID: 4414
			// (get) Token: 0x060054AF RID: 21679 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700113E")]
			public Button Next
			{
				[Token(Token = "0x60054AF")]
				[Address(RVA = "0xA25C", Offset = "0xA25C", VA = "0xA25C")]
				get
				{
					return null;
				}
			}

			// Token: 0x060054B0 RID: 21680 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60054B0")]
			[Address(RVA = "0xA25D", Offset = "0xA25D", VA = "0xA25D")]
			public Controls()
			{
			}

			// Token: 0x04002DDE RID: 11742
			[Token(Token = "0x4002DDE")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			private Button _back;

			// Token: 0x04002DDF RID: 11743
			[Token(Token = "0x4002DDF")]
			[FieldOffset(Offset = "0xC")]
			[SerializeField]
			private Button _next;
		}

		// Token: 0x02000D84 RID: 3460
		[Token(Token = "0x2000D84")]
		[Serializable]
		internal class TextControls
		{
			// Token: 0x1700113F RID: 4415
			// (get) Token: 0x060054B1 RID: 21681 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700113F")]
			public TMP_Text CurrentEffectLevelTitle
			{
				[Token(Token = "0x60054B1")]
				[Address(RVA = "0xA25E", Offset = "0xA25E", VA = "0xA25E")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001140 RID: 4416
			// (get) Token: 0x060054B2 RID: 21682 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17001140")]
			public TMP_Text CurrentLevel
			{
				[Token(Token = "0x60054B2")]
				[Address(RVA = "0xA25F", Offset = "0xA25F", VA = "0xA25F")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001141 RID: 4417
			// (get) Token: 0x060054B3 RID: 21683 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17001141")]
			public TMP_Text EffectLevelTitle
			{
				[Token(Token = "0x60054B3")]
				[Address(RVA = "0xA260", Offset = "0xA260", VA = "0xA260")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001142 RID: 4418
			// (get) Token: 0x060054B4 RID: 21684 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17001142")]
			public TMP_Text GetMethodDescription
			{
				[Token(Token = "0x60054B4")]
				[Address(RVA = "0xA261", Offset = "0xA261", VA = "0xA261")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001143 RID: 4419
			// (get) Token: 0x060054B5 RID: 21685 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17001143")]
			public TMP_Text GroupTitle
			{
				[Token(Token = "0x60054B5")]
				[Address(RVA = "0xA262", Offset = "0xA262", VA = "0xA262")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001144 RID: 4420
			// (get) Token: 0x060054B6 RID: 21686 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17001144")]
			public TMP_Text[] MaxLevel
			{
				[Token(Token = "0x60054B6")]
				[Address(RVA = "0xA263", Offset = "0xA263", VA = "0xA263")]
				get
				{
					return null;
				}
			}

			// Token: 0x060054B7 RID: 21687 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60054B7")]
			[Address(RVA = "0xA264", Offset = "0xA264", VA = "0xA264")]
			public TextControls()
			{
			}

			// Token: 0x04002DE0 RID: 11744
			[Token(Token = "0x4002DE0")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			private TMP_Text _currentEffectLevelTitle;

			// Token: 0x04002DE1 RID: 11745
			[Token(Token = "0x4002DE1")]
			[FieldOffset(Offset = "0xC")]
			[SerializeField]
			private TMP_Text _currentLevel;

			// Token: 0x04002DE2 RID: 11746
			[Token(Token = "0x4002DE2")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private TMP_Text _effectLevelTitle;

			// Token: 0x04002DE3 RID: 11747
			[Token(Token = "0x4002DE3")]
			[FieldOffset(Offset = "0x14")]
			[SerializeField]
			private TMP_Text _getMethodDescription;

			// Token: 0x04002DE4 RID: 11748
			[Token(Token = "0x4002DE4")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private TMP_Text _groupTitle;

			// Token: 0x04002DE5 RID: 11749
			[Token(Token = "0x4002DE5")]
			[FieldOffset(Offset = "0x1C")]
			[SerializeField]
			private TMP_Text[] _maxLevel;
		}
	}
}
