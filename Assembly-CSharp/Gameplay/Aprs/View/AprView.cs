using System;
using System.Runtime.CompilerServices;
using AssetContent;
using AssetContent.Loaders;
using Core;
using Core.Dict.DictWrappers.Wrappers;
using Core.Gameplay;
using Gameplay.Aprs.Model;
using Gameplay.Tutorial.Guide.Model.Data;
using Il2CppDummyDll;
using UI;
using UI.ToolTip;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Gameplay.Aprs.View
{
	// Token: 0x02000D52 RID: 3410
	[Token(Token = "0x2000D52")]
	public class AprView : AbstractDataRenderer<AprDicWrapper>, IAprView, IToolTipDataProvider, IPointerClickHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler
	{
		// Token: 0x140001FD RID: 509
		// (add) Token: 0x06005384 RID: 21380 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06005385 RID: 21381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001FD")]
		public event Action<AprView> ClickEvent
		{
			[Token(Token = "0x6005384")]
			[Address(RVA = "0xA143", Offset = "0xA143", VA = "0xA143")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005385")]
			[Address(RVA = "0xA144", Offset = "0xA144", VA = "0xA144")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140001FE RID: 510
		// (add) Token: 0x06005386 RID: 21382 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06005387 RID: 21383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001FE")]
		public static event Action RequestNotifyStencilStateChangedEvent
		{
			[Token(Token = "0x6005386")]
			[Address(RVA = "0xA145", Offset = "0xA145", VA = "0xA145")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005387")]
			[Address(RVA = "0xA146", Offset = "0xA146", VA = "0xA146")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170010FA RID: 4346
		// (get) Token: 0x06005388 RID: 21384 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170010FA")]
		public IGuideTarget GuideTarget
		{
			[Token(Token = "0x6005388")]
			[Address(RVA = "0xA147", Offset = "0xA147", VA = "0xA147")]
			get
			{
				return null;
			}
		}

		// Token: 0x170010FB RID: 4347
		// (get) Token: 0x06005389 RID: 21385 RVA: 0x0000F180 File Offset: 0x0000D380
		// (set) Token: 0x0600538A RID: 21386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010FB")]
		public InteractiveBehavior Mode
		{
			[Token(Token = "0x6005389")]
			[Address(RVA = "0xA148", Offset = "0xA148", VA = "0xA148")]
			[CompilerGenerated]
			get
			{
				return InteractiveBehavior.Default;
			}
			[Token(Token = "0x600538A")]
			[Address(RVA = "0xA149", Offset = "0xA149", VA = "0xA149")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170010FC RID: 4348
		// (get) Token: 0x0600538B RID: 21387 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600538C RID: 21388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010FC")]
		public AprGridView AprGridView
		{
			[Token(Token = "0x600538B")]
			[Address(RVA = "0xA14A", Offset = "0xA14A", VA = "0xA14A")]
			get
			{
				return null;
			}
			[Token(Token = "0x600538C")]
			[Address(RVA = "0xA14B", Offset = "0xA14B", VA = "0xA14B")]
			set
			{
			}
		}

		// Token: 0x170010FD RID: 4349
		// (get) Token: 0x0600538D RID: 21389 RVA: 0x0000F198 File Offset: 0x0000D398
		// (set) Token: 0x0600538E RID: 21390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010FD")]
		public bool Achieved
		{
			[Token(Token = "0x600538D")]
			[Address(RVA = "0xA14C", Offset = "0xA14C", VA = "0xA14C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600538E")]
			[Address(RVA = "0xA14D", Offset = "0xA14D", VA = "0xA14D")]
			set
			{
			}
		}

		// Token: 0x170010FE RID: 4350
		// (get) Token: 0x0600538F RID: 21391 RVA: 0x0000F1B0 File Offset: 0x0000D3B0
		// (set) Token: 0x06005390 RID: 21392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010FE")]
		private bool IsPointerOver
		{
			[Token(Token = "0x600538F")]
			[Address(RVA = "0xA14E", Offset = "0xA14E", VA = "0xA14E")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005390")]
			[Address(RVA = "0xA14F", Offset = "0xA14F", VA = "0xA14F")]
			set
			{
			}
		}

		// Token: 0x06005391 RID: 21393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005391")]
		[Address(RVA = "0xA150", Offset = "0xA150", VA = "0xA150")]
		private void HandleAchievedChanged()
		{
		}

		// Token: 0x06005392 RID: 21394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005392")]
		[Address(RVA = "0xA151", Offset = "0xA151", VA = "0xA151")]
		private void HandleIsPointerOverChanged()
		{
		}

		// Token: 0x06005393 RID: 21395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005393")]
		[Address(RVA = "0xA152", Offset = "0xA152", VA = "0xA152")]
		private void ValidateGrayScale()
		{
		}

		// Token: 0x06005394 RID: 21396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005394")]
		[Address(RVA = "0xA153", Offset = "0xA153", VA = "0xA153")]
		private void DrawRibbon()
		{
		}

		// Token: 0x06005395 RID: 21397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005395")]
		[Address(RVA = "0xA154", Offset = "0xA154", VA = "0xA154", Slot = "19")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x06005396 RID: 21398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005396")]
		[Address(RVA = "0xA155", Offset = "0xA155", VA = "0xA155", Slot = "26")]
		protected virtual void SetAsset(AprDicWrapper data)
		{
		}

		// Token: 0x06005397 RID: 21399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005397")]
		[Address(RVA = "0xA156", Offset = "0xA156", VA = "0xA156")]
		private void HandleDiscountWidget()
		{
		}

		// Token: 0x06005398 RID: 21400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005398")]
		[Address(RVA = "0xA157", Offset = "0xA157", VA = "0xA157", Slot = "9")]
		protected override void Awake()
		{
		}

		// Token: 0x06005399 RID: 21401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005399")]
		[Address(RVA = "0xA158", Offset = "0xA158", VA = "0xA158", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x0600539A RID: 21402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600539A")]
		[Address(RVA = "0xA159", Offset = "0xA159", VA = "0xA159", Slot = "10")]
		public override void Dispose()
		{
		}

		// Token: 0x0600539B RID: 21403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600539B")]
		[Address(RVA = "0xA15A", Offset = "0xA15A", VA = "0xA15A", Slot = "27")]
		public virtual void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x0600539C RID: 21404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600539C")]
		[Address(RVA = "0xA15B", Offset = "0xA15B", VA = "0xA15B", Slot = "24")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		// Token: 0x0600539D RID: 21405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600539D")]
		[Address(RVA = "0xA15C", Offset = "0xA15C", VA = "0xA15C", Slot = "25")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		// Token: 0x0600539E RID: 21406 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600539E")]
		[Address(RVA = "0xA15D", Offset = "0xA15D", VA = "0xA15D")]
		public AprData GetAprData()
		{
			return null;
		}

		// Token: 0x0600539F RID: 21407 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600539F")]
		[Address(RVA = "0xA15E", Offset = "0xA15E", VA = "0xA15E", Slot = "22")]
		public BaseToolTipData GetData()
		{
			return null;
		}

		// Token: 0x060053A0 RID: 21408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053A0")]
		[Address(RVA = "0xA15F", Offset = "0xA15F", VA = "0xA15F", Slot = "17")]
		protected override void StartListenEvents(AprDicWrapper data)
		{
		}

		// Token: 0x060053A1 RID: 21409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053A1")]
		[Address(RVA = "0xA160", Offset = "0xA160", VA = "0xA160", Slot = "18")]
		protected override void StopListenEvents(AprDicWrapper data)
		{
		}

		// Token: 0x060053A2 RID: 21410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053A2")]
		[Address(RVA = "0xA161", Offset = "0xA161", VA = "0xA161")]
		private void DataOnDataChangedEvent()
		{
		}

		// Token: 0x060053A3 RID: 21411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053A3")]
		[Address(RVA = "0xA162", Offset = "0xA162", VA = "0xA162")]
		public void SetGrayscale(float value, float duration)
		{
		}

		// Token: 0x060053A4 RID: 21412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053A4")]
		[Address(RVA = "0xA163", Offset = "0xA163", VA = "0xA163")]
		public AprView()
		{
		}

		// Token: 0x04002D45 RID: 11589
		[Token(Token = "0x4002D45")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		protected GameAssetViewRawImage _gameAssetView;

		// Token: 0x04002D46 RID: 11590
		[Token(Token = "0x4002D46")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected GameRawImageLoader _ribbon;

		// Token: 0x04002D47 RID: 11591
		[Token(Token = "0x4002D47")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Image _bg;

		// Token: 0x04002D48 RID: 11592
		[Token(Token = "0x4002D48")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Sprite _bgDefaultSprite;

		// Token: 0x04002D49 RID: 11593
		[Token(Token = "0x4002D49")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Sprite _bgSilverSprite;

		// Token: 0x04002D4A RID: 11594
		[Token(Token = "0x4002D4A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Sprite _bgGoldSprite;

		// Token: 0x04002D4B RID: 11595
		[Token(Token = "0x4002D4B")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private ToolTip _toolTip;

		// Token: 0x04002D4C RID: 11596
		[Token(Token = "0x4002D4C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool _use128Asset;

		// Token: 0x04002D4F RID: 11599
		[Token(Token = "0x4002D4F")]
		[FieldOffset(Offset = "0x48")]
		private IGuideTarget _guideTarget;

		// Token: 0x04002D50 RID: 11600
		[Token(Token = "0x4002D50")]
		[FieldOffset(Offset = "0x4C")]
		private AprGridView _aprGridView;

		// Token: 0x04002D51 RID: 11601
		[Token(Token = "0x4002D51")]
		[FieldOffset(Offset = "0x50")]
		protected IGame _game;

		// Token: 0x04002D52 RID: 11602
		[Token(Token = "0x4002D52")]
		[FieldOffset(Offset = "0x54")]
		private bool _isPointerOver;

		// Token: 0x04002D53 RID: 11603
		[Token(Token = "0x4002D53")]
		[FieldOffset(Offset = "0x55")]
		private bool _achieved;
	}
}
