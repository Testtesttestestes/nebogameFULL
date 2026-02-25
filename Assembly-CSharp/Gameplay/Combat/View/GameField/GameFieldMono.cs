using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data.User;
using Cysharp.Threading.Tasks;
using Gameplay.Combat.Model;
using Gameplay.Combat.View.Animations;
using Gameplay.Combat.View.GameField.Hint;
using Gameplay.Combat.View.Spells;
using Gameplay.Input;
using Il2CppDummyDll;
using Protocol.Combat;
using UnityEngine;
using Utils.Cache;

namespace Gameplay.Combat.View.GameField
{
	// Token: 0x02000963 RID: 2403
	[Token(Token = "0x2000963")]
	public class GameFieldMono : BaseGameFieldMono
	{
		// Token: 0x14000182 RID: 386
		// (add) Token: 0x06003906 RID: 14598 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06003907 RID: 14599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000182")]
		public event Action OnStoneDestroyed
		{
			[Token(Token = "0x6003906")]
			[Address(RVA = "0x88A3", Offset = "0x88A3", VA = "0x88A3")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003907")]
			[Address(RVA = "0x88A4", Offset = "0x88A4", VA = "0x88A4")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000183 RID: 387
		// (add) Token: 0x06003908 RID: 14600 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06003909 RID: 14601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000183")]
		public event Action OnGameOver
		{
			[Token(Token = "0x6003908")]
			[Address(RVA = "0x88A5", Offset = "0x88A5", VA = "0x88A5")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003909")]
			[Address(RVA = "0x88A6", Offset = "0x88A6", VA = "0x88A6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000184 RID: 388
		// (add) Token: 0x0600390A RID: 14602 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600390B RID: 14603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000184")]
		public event Action OnInteractiveChanged
		{
			[Token(Token = "0x600390A")]
			[Address(RVA = "0x88A7", Offset = "0x88A7", VA = "0x88A7")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600390B")]
			[Address(RVA = "0x88A8", Offset = "0x88A8", VA = "0x88A8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000B38 RID: 2872
		// (get) Token: 0x0600390C RID: 14604 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000B38")]
		public StoneMono.StoneSkinProvider StoneSkin
		{
			[Token(Token = "0x600390C")]
			[Address(RVA = "0x88A9", Offset = "0x88A9", VA = "0x88A9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B39 RID: 2873
		// (get) Token: 0x0600390D RID: 14605 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000B39")]
		public SpellFieldFigure SpellFieldFigure
		{
			[Token(Token = "0x600390D")]
			[Address(RVA = "0x88AA", Offset = "0x88AA", VA = "0x88AA")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B3A RID: 2874
		// (get) Token: 0x0600390E RID: 14606 RVA: 0x0000B538 File Offset: 0x00009738
		// (set) Token: 0x0600390F RID: 14607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B3A")]
		public bool FieldBlackoutVisible
		{
			[Token(Token = "0x600390E")]
			[Address(RVA = "0x88AB", Offset = "0x88AB", VA = "0x88AB")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600390F")]
			[Address(RVA = "0x88AC", Offset = "0x88AC", VA = "0x88AC")]
			set
			{
			}
		}

		// Token: 0x17000B3B RID: 2875
		// (get) Token: 0x06003910 RID: 14608 RVA: 0x0000B550 File Offset: 0x00009750
		// (set) Token: 0x06003911 RID: 14609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B3B")]
		public bool IsInteractive
		{
			[Token(Token = "0x6003910")]
			[Address(RVA = "0x88AD", Offset = "0x88AD", VA = "0x88AD")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003911")]
			[Address(RVA = "0x37A6", Offset = "0x37A6", VA = "0x37A6")]
			set
			{
			}
		}

		// Token: 0x17000B3C RID: 2876
		// (get) Token: 0x06003912 RID: 14610 RVA: 0x0000B568 File Offset: 0x00009768
		// (set) Token: 0x06003913 RID: 14611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B3C")]
		public bool EnableFollowFieldEffectFigureOnPointer
		{
			[Token(Token = "0x6003912")]
			[Address(RVA = "0x88AE", Offset = "0x88AE", VA = "0x88AE")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003913")]
			[Address(RVA = "0x88AF", Offset = "0x88AF", VA = "0x88AF")]
			set
			{
			}
		}

		// Token: 0x06003914 RID: 14612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003914")]
		[Address(RVA = "0x88B0", Offset = "0x88B0", VA = "0x88B0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06003915 RID: 14613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003915")]
		[Address(RVA = "0x88B1", Offset = "0x88B1", VA = "0x88B1")]
		private void Awake()
		{
		}

		// Token: 0x06003916 RID: 14614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003916")]
		[Address(RVA = "0x88B2", Offset = "0x88B2", VA = "0x88B2")]
		private void ResetGlowPoolObjectCallback(StoneGlow pooledObject)
		{
		}

		// Token: 0x06003917 RID: 14615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003917")]
		[Address(RVA = "0x88B3", Offset = "0x88B3", VA = "0x88B3")]
		private void ResetPoolObjectCallback(StoneMono pooledObject)
		{
		}

		// Token: 0x06003918 RID: 14616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003918")]
		[Address(RVA = "0x88B4", Offset = "0x88B4", VA = "0x88B4")]
		private void HandleIsInteractiveChanged()
		{
		}

		// Token: 0x06003919 RID: 14617 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003919")]
		[Address(RVA = "0x88B5", Offset = "0x88B5", VA = "0x88B5")]
		private StoneMono AddStone(StonesTypes type, int col, int row, float duration, float delay = 0f)
		{
			return null;
		}

		// Token: 0x0600391A RID: 14618 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600391A")]
		[Address(RVA = "0x19E3", Offset = "0x19E3", VA = "0x19E3")]
		private StoneMono AddStoneFromCenter(StonesTypes type, int col, int row, float duration)
		{
			return null;
		}

		// Token: 0x0600391B RID: 14619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600391B")]
		[Address(RVA = "0x88B6", Offset = "0x88B6", VA = "0x88B6")]
		private void Update()
		{
		}

		// Token: 0x0600391C RID: 14620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600391C")]
		[Address(RVA = "0x88B7", Offset = "0x88B7", VA = "0x88B7")]
		private void MoveFieldEffectFigureOnPointer()
		{
		}

		// Token: 0x0600391D RID: 14621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600391D")]
		[Address(RVA = "0x88B8", Offset = "0x88B8", VA = "0x88B8")]
		private void StartWinAnimation()
		{
		}

		// Token: 0x0600391E RID: 14622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600391E")]
		[Address(RVA = "0x88B9", Offset = "0x88B9", VA = "0x88B9")]
		private void StartLoseAnimation()
		{
		}

		// Token: 0x0600391F RID: 14623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600391F")]
		[Address(RVA = "0x88BA", Offset = "0x88BA", VA = "0x88BA", Slot = "6")]
		public override void InitField(GameFieldGamesData fieldData, UserSettings settings, float swapDuration)
		{
		}

		// Token: 0x06003920 RID: 14624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003920")]
		[Address(RVA = "0x37A8", Offset = "0x37A8", VA = "0x37A8")]
		public void ShowAddStones(IList<CellInfo> stones, float duration)
		{
		}

		// Token: 0x06003921 RID: 14625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003921")]
		[Address(RVA = "0x37A7", Offset = "0x37A7", VA = "0x37A7")]
		public void ShowAddStonesFromCenter(IList<CellInfo> cells, float duration)
		{
		}

		// Token: 0x06003922 RID: 14626 RVA: 0x0000B580 File Offset: 0x00009780
		[Token(Token = "0x6003922")]
		[Address(RVA = "0x37AC", Offset = "0x37AC", VA = "0x37AC")]
		public UniTask ShowDestroyStones(List<StoneMono> stones, float destroyDuration, float shiftDuration)
		{
			return default(UniTask);
		}

		// Token: 0x06003923 RID: 14627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003923")]
		[Address(RVA = "0x37AF", Offset = "0x37AF", VA = "0x37AF")]
		public void ShowSwapStones(int fromX, int fromY, int toX, int toY, float duration)
		{
		}

		// Token: 0x06003924 RID: 14628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003924")]
		[Address(RVA = "0x37B3", Offset = "0x37B3", VA = "0x37B3")]
		public void ShowClearFieldToCenter(float duration)
		{
		}

		// Token: 0x06003925 RID: 14629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003925")]
		[Address(RVA = "0x88BB", Offset = "0x88BB", VA = "0x88BB")]
		public void ShowEndAnimation(GameOverData gameOver)
		{
		}

		// Token: 0x06003926 RID: 14630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003926")]
		[Address(RVA = "0x88BC", Offset = "0x88BC", VA = "0x88BC", Slot = "7")]
		public override void HandlePressDown(IPlayerInput input)
		{
		}

		// Token: 0x06003927 RID: 14631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003927")]
		[Address(RVA = "0x88BD", Offset = "0x88BD", VA = "0x88BD")]
		public void HideHint()
		{
		}

		// Token: 0x06003928 RID: 14632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003928")]
		[Address(RVA = "0x1C30", Offset = "0x1C30", VA = "0x1C30")]
		public void Glow(StoneMono stone, out float duration)
		{
		}

		// Token: 0x06003929 RID: 14633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003929")]
		[Address(RVA = "0x88BE", Offset = "0x88BE", VA = "0x88BE")]
		public GameFieldMono()
		{
		}

		// Token: 0x04001F87 RID: 8071
		[Token(Token = "0x4001F87")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private StoneMono _stonePrefab;

		// Token: 0x04001F88 RID: 8072
		[Token(Token = "0x4001F88")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private Transform _stoneParent;

		// Token: 0x04001F89 RID: 8073
		[Token(Token = "0x4001F89")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private StoneGlow _stoneGlow;

		// Token: 0x04001F8A RID: 8074
		[Token(Token = "0x4001F8A")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private Transform _glowParent;

		// Token: 0x04001F8B RID: 8075
		[Token(Token = "0x4001F8B")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private SpriteRenderer _fieldBlockSpriteRenderer;

		// Token: 0x04001F8C RID: 8076
		[Token(Token = "0x4001F8C")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private SpellFieldFigure _spellfieldFigure;

		// Token: 0x04001F8D RID: 8077
		[Token(Token = "0x4001F8D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CombatAnimationsMode _animationsConfig;

		// Token: 0x04001F8E RID: 8078
		[Token(Token = "0x4001F8E")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private WinFieldAnimation _winAnimation;

		// Token: 0x04001F8F RID: 8079
		[Token(Token = "0x4001F8F")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private LoseFieldAnimation _loseAnimation;

		// Token: 0x04001F90 RID: 8080
		[Token(Token = "0x4001F90")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private int _startStoneSpawnY;

		// Token: 0x04001F91 RID: 8081
		[Token(Token = "0x4001F91")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private float _clearCenterRotate;

		// Token: 0x04001F92 RID: 8082
		[Token(Token = "0x4001F92")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		private float _clearCenterFade;

		// Token: 0x04001F93 RID: 8083
		[Token(Token = "0x4001F93")]
		[FieldOffset(Offset = "0x88")]
		private readonly List<StoneGlow> _activeGlows;

		// Token: 0x04001F94 RID: 8084
		[Token(Token = "0x4001F94")]
		[FieldOffset(Offset = "0x8C")]
		private GameFieldMono.ImpactDelegate _impact;

		// Token: 0x04001F95 RID: 8085
		[Token(Token = "0x4001F95")]
		[FieldOffset(Offset = "0x90")]
		private GameObjectPool<StoneMono> _stonePool;

		// Token: 0x04001F96 RID: 8086
		[Token(Token = "0x4001F96")]
		[FieldOffset(Offset = "0x94")]
		private GameObjectPool<StoneGlow> _stoneGlowPool;

		// Token: 0x04001F97 RID: 8087
		[Token(Token = "0x4001F97")]
		[FieldOffset(Offset = "0x98")]
		private IPool<IStoneParticles> _particlesPool;

		// Token: 0x04001F98 RID: 8088
		[Token(Token = "0x4001F98")]
		[FieldOffset(Offset = "0x9C")]
		private BoxCollider2D _collider;

		// Token: 0x04001F99 RID: 8089
		[Token(Token = "0x4001F99")]
		[FieldOffset(Offset = "0xA0")]
		private Vector3 _lastMousePosition;

		// Token: 0x04001F9A RID: 8090
		[Token(Token = "0x4001F9A")]
		[FieldOffset(Offset = "0xAC")]
		private GameFieldGamesData _fieldData;

		// Token: 0x04001F9B RID: 8091
		[Token(Token = "0x4001F9B")]
		[FieldOffset(Offset = "0xB0")]
		private int _inBoundsCount;

		// Token: 0x04001F9C RID: 8092
		[Token(Token = "0x4001F9C")]
		[FieldOffset(Offset = "0xB4")]
		private bool _isInteractive;

		// Token: 0x04001F9D RID: 8093
		[Token(Token = "0x4001F9D")]
		[FieldOffset(Offset = "0xB5")]
		private bool _enableFollowFieldEffectFigureOnPointer;

		// Token: 0x04001F9E RID: 8094
		[Token(Token = "0x4001F9E")]
		[FieldOffset(Offset = "0xB6")]
		private bool _fieldBlackoutVisible;

		// Token: 0x02000964 RID: 2404
		// (Invoke) Token: 0x0600392B RID: 14635
		[Token(Token = "0x2000964")]
		public delegate void ImpactDelegate(IEnumerable<StoneMono> stones, StoneMono[,] allStones);
	}
}
