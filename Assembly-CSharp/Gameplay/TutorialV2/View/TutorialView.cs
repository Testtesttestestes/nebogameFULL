using System;
using AssetContent;
using Gameplay.RegisterV2.View;
using Gameplay.Tutorial.Guide.View;
using Gameplay.Tutorial.Guide.View.Components;
using Gameplay.TutorialCombatV2.View;
using Il2CppDummyDll;
using UI;
using UnityEngine;
using UnityEngine.UI;
using Utils;

namespace Gameplay.TutorialV2.View
{
	// Token: 0x0200042D RID: 1069
	[Token(Token = "0x200042D")]
	public class TutorialView : MonoBehaviourWithStates<TutorialView.States>, ITutorialView
	{
		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06001946 RID: 6470 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700046E")]
		public ShapePointer CombatOverlap
		{
			[Token(Token = "0x6001946")]
			[Address(RVA = "0x6AE5", Offset = "0x6AE5", VA = "0x6AE5")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06001947 RID: 6471 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700046F")]
		public GameAssetViewSpriteRenderer LeftPlayer
		{
			[Token(Token = "0x6001947")]
			[Address(RVA = "0x6AE6", Offset = "0x6AE6", VA = "0x6AE6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06001948 RID: 6472 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000470")]
		public GameAssetViewSpriteRenderer RightPlayer
		{
			[Token(Token = "0x6001948")]
			[Address(RVA = "0x6AE7", Offset = "0x6AE7", VA = "0x6AE7")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06001949 RID: 6473 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000471")]
		public MonoPointerClickHandler ClickHandler
		{
			[Token(Token = "0x6001949")]
			[Address(RVA = "0x6AE8", Offset = "0x6AE8", VA = "0x6AE8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x0600194A RID: 6474 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000472")]
		public TutorialCombatView CombatView
		{
			[Token(Token = "0x600194A")]
			[Address(RVA = "0x6AE9", Offset = "0x6AE9", VA = "0x6AE9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x0600194B RID: 6475 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000473")]
		public PodiumTweens PodiumTweens
		{
			[Token(Token = "0x600194B")]
			[Address(RVA = "0x6AEA", Offset = "0x6AEA", VA = "0x6AEA")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x0600194C RID: 6476 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000474")]
		public Transform RegistrationViewParent
		{
			[Token(Token = "0x600194C")]
			[Address(RVA = "0x6AEB", Offset = "0x6AEB", VA = "0x6AEB")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x0600194D RID: 6477 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000475")]
		public GraphicPointerView PointerView
		{
			[Token(Token = "0x600194D")]
			[Address(RVA = "0x6AEC", Offset = "0x6AEC", VA = "0x6AEC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x0600194E RID: 6478 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000476")]
		public MessageBubbleView MessageBubble
		{
			[Token(Token = "0x600194E")]
			[Address(RVA = "0x6AED", Offset = "0x6AED", VA = "0x6AED")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x0600194F RID: 6479 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000477")]
		public Button StartCombatButton
		{
			[Token(Token = "0x600194F")]
			[Address(RVA = "0x6AEE", Offset = "0x6AEE", VA = "0x6AEE")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06001950 RID: 6480 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000478")]
		public Sprite[] OverlapSprites
		{
			[Token(Token = "0x6001950")]
			[Address(RVA = "0x6AEF", Offset = "0x6AEF", VA = "0x6AEF")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06001951 RID: 6481 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000479")]
		public RegistrationView RegistrationView
		{
			[Token(Token = "0x6001951")]
			[Address(RVA = "0x6AF0", Offset = "0x6AF0", VA = "0x6AF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001952 RID: 6482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001952")]
		[Address(RVA = "0x6AF1", Offset = "0x6AF1", VA = "0x6AF1")]
		private void Start()
		{
		}

		// Token: 0x06001953 RID: 6483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001953")]
		[Address(RVA = "0x6AF2", Offset = "0x6AF2", VA = "0x6AF2")]
		public TutorialView()
		{
		}

		// Token: 0x04000D5E RID: 3422
		[Token(Token = "0x4000D5E")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private MonoPointerClickHandler _clickHandler;

		// Token: 0x04000D5F RID: 3423
		[Token(Token = "0x4000D5F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameAssetViewSpriteRenderer _leftPlayer;

		// Token: 0x04000D60 RID: 3424
		[Token(Token = "0x4000D60")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private GameAssetViewSpriteRenderer _rightPlayer;

		// Token: 0x04000D61 RID: 3425
		[Token(Token = "0x4000D61")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TutorialCombatView _combatView;

		// Token: 0x04000D62 RID: 3426
		[Token(Token = "0x4000D62")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private PodiumTweens _podiumTweens;

		// Token: 0x04000D63 RID: 3427
		[Token(Token = "0x4000D63")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _registrationViewParent;

		// Token: 0x04000D64 RID: 3428
		[Token(Token = "0x4000D64")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private GraphicPointerView _pointerView;

		// Token: 0x04000D65 RID: 3429
		[Token(Token = "0x4000D65")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private MessageBubbleView _messageBubble;

		// Token: 0x04000D66 RID: 3430
		[Token(Token = "0x4000D66")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Button _startCombatButton;

		// Token: 0x04000D67 RID: 3431
		[Token(Token = "0x4000D67")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ShapePointer _combatPointer;

		// Token: 0x04000D68 RID: 3432
		[Token(Token = "0x4000D68")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private Sprite[] _overlapSprites;

		// Token: 0x04000D69 RID: 3433
		[Token(Token = "0x4000D69")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RegistrationView _registrationView;

		// Token: 0x0200042E RID: 1070
		[Token(Token = "0x200042E")]
		public enum States
		{
			// Token: 0x04000D6B RID: 3435
			[Token(Token = "0x4000D6B")]
			UNKNOWN_STATE,
			// Token: 0x04000D6C RID: 3436
			[Token(Token = "0x4000D6C")]
			SHOW_COMBAT_BUTTON,
			// Token: 0x04000D6D RID: 3437
			[Token(Token = "0x4000D6D")]
			START_COMBAT,
			// Token: 0x04000D6E RID: 3438
			[Token(Token = "0x4000D6E")]
			GO_TO_REGISTARTION,
			// Token: 0x04000D6F RID: 3439
			[Token(Token = "0x4000D6F")]
			REGISTARTION
		}
	}
}
