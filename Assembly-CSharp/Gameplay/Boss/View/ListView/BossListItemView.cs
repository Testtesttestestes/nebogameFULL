using System;
using System.Runtime.CompilerServices;
using AssetContent;
using Gameplay.Boss.Model;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.Elements.Counters;
using UI.Elements.ProgressBars;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Utils;

namespace Gameplay.Boss.View.ListView
{
	// Token: 0x02000B6A RID: 2922
	[Token(Token = "0x2000B6A")]
	public class BossListItemView : MonoBehaviour
	{
		// Token: 0x140001BC RID: 444
		// (add) Token: 0x060046E9 RID: 18153 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060046EA RID: 18154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001BC")]
		public event Action<BossInstance> SelectedEvent
		{
			[Token(Token = "0x60046E9")]
			[Address(RVA = "0x957F", Offset = "0x957F", VA = "0x957F")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60046EA")]
			[Address(RVA = "0x9580", Offset = "0x9580", VA = "0x9580")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140001BD RID: 445
		// (add) Token: 0x060046EB RID: 18155 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060046EC RID: 18156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001BD")]
		public event Action<BossInstance> QuestionClickedEvent
		{
			[Token(Token = "0x60046EB")]
			[Address(RVA = "0x9581", Offset = "0x9581", VA = "0x9581")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60046EC")]
			[Address(RVA = "0x9582", Offset = "0x9582", VA = "0x9582")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060046ED RID: 18157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046ED")]
		[Address(RVA = "0x9583", Offset = "0x9583", VA = "0x9583")]
		private void OnDestroy()
		{
		}

		// Token: 0x060046EE RID: 18158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046EE")]
		[Address(RVA = "0x9584", Offset = "0x9584", VA = "0x9584")]
		private void Awake()
		{
		}

		// Token: 0x060046EF RID: 18159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046EF")]
		[Address(RVA = "0x9585", Offset = "0x9585", VA = "0x9585")]
		private void QuestionButtonClickHandler()
		{
		}

		// Token: 0x060046F0 RID: 18160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046F0")]
		[Address(RVA = "0x9586", Offset = "0x9586", VA = "0x9586")]
		private void MonoPointerClickHandlerOnOnClickEvent(PointerEventData obj)
		{
		}

		// Token: 0x17000E14 RID: 3604
		// (get) Token: 0x060046F1 RID: 18161 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060046F2 RID: 18162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E14")]
		public BossInstance BossInstance
		{
			[Token(Token = "0x60046F1")]
			[Address(RVA = "0x9587", Offset = "0x9587", VA = "0x9587")]
			get
			{
				return null;
			}
			[Token(Token = "0x60046F2")]
			[Address(RVA = "0x9588", Offset = "0x9588", VA = "0x9588")]
			set
			{
			}
		}

		// Token: 0x17000E15 RID: 3605
		// (set) Token: 0x060046F3 RID: 18163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E15")]
		public bool Selected
		{
			[Token(Token = "0x60046F3")]
			[Address(RVA = "0x9589", Offset = "0x9589", VA = "0x9589")]
			set
			{
			}
		}

		// Token: 0x060046F4 RID: 18164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046F4")]
		[Address(RVA = "0x958A", Offset = "0x958A", VA = "0x958A")]
		public BossListItemView()
		{
		}

		// Token: 0x040026D2 RID: 9938
		[Token(Token = "0x40026D2")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _label;

		// Token: 0x040026D3 RID: 9939
		[Token(Token = "0x40026D3")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _healthValue;

		// Token: 0x040026D4 RID: 9940
		[Token(Token = "0x40026D4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _bg;

		// Token: 0x040026D5 RID: 9941
		[Token(Token = "0x40026D5")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Image _selectedImage;

		// Token: 0x040026D6 RID: 9942
		[Token(Token = "0x40026D6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sprite _bgAlive;

		// Token: 0x040026D7 RID: 9943
		[Token(Token = "0x40026D7")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Sprite _bgAliveNa;

		// Token: 0x040026D8 RID: 9944
		[Token(Token = "0x40026D8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Sprite _bgDefault;

		// Token: 0x040026D9 RID: 9945
		[Token(Token = "0x40026D9")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private MonoPointerClickHandler _monoPointerClickHandler;

		// Token: 0x040026DA RID: 9946
		[Token(Token = "0x40026DA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ProgressBar _progressBar;

		// Token: 0x040026DB RID: 9947
		[Token(Token = "0x40026DB")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private BacktimeViewUGUI _backtimeViewUGUI;

		// Token: 0x040026DC RID: 9948
		[Token(Token = "0x40026DC")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameAssetViewRawImage _gameAssetViewRawImage;

		// Token: 0x040026DD RID: 9949
		[Token(Token = "0x40026DD")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private CounterAutoHide _counter;

		// Token: 0x040026DE RID: 9950
		[Token(Token = "0x40026DE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private LevelCounter _level;

		// Token: 0x040026DF RID: 9951
		[Token(Token = "0x40026DF")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private Image _heartIcon;

		// Token: 0x040026E0 RID: 9952
		[Token(Token = "0x40026E0")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _giftIcon;

		// Token: 0x040026E1 RID: 9953
		[Token(Token = "0x40026E1")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private Image _swordsGiftIcon;

		// Token: 0x040026E4 RID: 9956
		[Token(Token = "0x40026E4")]
		[FieldOffset(Offset = "0x58")]
		private BossInstance _bossInstance;
	}
}
