using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Core.Animations;
using DG.Tweening;
using Gameplay.Combat.Control;
using Gameplay.Combat.View.Animations;
using Gameplay.Combat.View.Players.Pet;
using Il2CppDummyDll;
using Protocol.Combat;
using UnityEngine;
using UnityEngine.UI;
using Utils.Cache;

namespace Gameplay.Combat.View.VFX
{
	// Token: 0x0200092A RID: 2346
	[Token(Token = "0x200092A")]
	public class StoneDestroyElement : MonoBehaviour, CombatAnimation.IContent, IDisposable, IConveyorItem, IPoolElement<StoneDestroyElement>
	{
		// Token: 0x14000177 RID: 375
		// (add) Token: 0x06003746 RID: 14150 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06003747 RID: 14151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000177")]
		public event Action<CombatAnimation.IContent> OnCompleteEvent
		{
			[Token(Token = "0x6003746")]
			[Address(RVA = "0x8734", Offset = "0x8734", VA = "0x8734", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003747")]
			[Address(RVA = "0x8735", Offset = "0x8735", VA = "0x8735", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000AEA RID: 2794
		// (get) Token: 0x06003748 RID: 14152 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000AEA")]
		public Transform Transform
		{
			[Token(Token = "0x6003748")]
			[Address(RVA = "0x8736", Offset = "0x8736", VA = "0x8736", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AEB RID: 2795
		// (get) Token: 0x06003749 RID: 14153 RVA: 0x0000B148 File Offset: 0x00009348
		[Token(Token = "0x17000AEB")]
		public StonesTypes Stone
		{
			[Token(Token = "0x6003749")]
			[Address(RVA = "0x8737", Offset = "0x8737", VA = "0x8737")]
			get
			{
				return StonesTypes.Empty;
			}
		}

		// Token: 0x17000AEC RID: 2796
		// (get) Token: 0x0600374A RID: 14154 RVA: 0x0000B160 File Offset: 0x00009360
		// (set) Token: 0x0600374B RID: 14155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AEC")]
		public float Duration
		{
			[Token(Token = "0x600374A")]
			[Address(RVA = "0x8738", Offset = "0x8738", VA = "0x8738", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600374B")]
			[Address(RVA = "0x8739", Offset = "0x8739", VA = "0x8739")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000AED RID: 2797
		// (get) Token: 0x0600374C RID: 14156 RVA: 0x0000B178 File Offset: 0x00009378
		// (set) Token: 0x0600374D RID: 14157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AED")]
		public float Delay
		{
			[Token(Token = "0x600374C")]
			[Address(RVA = "0x873A", Offset = "0x873A", VA = "0x873A", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600374D")]
			[Address(RVA = "0x873B", Offset = "0x873B", VA = "0x873B")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000AEE RID: 2798
		// (get) Token: 0x0600374E RID: 14158 RVA: 0x0000B190 File Offset: 0x00009390
		// (set) Token: 0x0600374F RID: 14159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AEE")]
		public bool IsLeft
		{
			[Token(Token = "0x600374E")]
			[Address(RVA = "0x873C", Offset = "0x873C", VA = "0x873C", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600374F")]
			[Address(RVA = "0x873D", Offset = "0x873D", VA = "0x873D", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000AEF RID: 2799
		// (get) Token: 0x06003750 RID: 14160 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003751 RID: 14161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AEF")]
		public ObjectPool<StoneDestroyElement> Pool
		{
			[Token(Token = "0x6003750")]
			[Address(RVA = "0x873E", Offset = "0x873E", VA = "0x873E", Slot = "15")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003751")]
			[Address(RVA = "0x873F", Offset = "0x873F", VA = "0x873F", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x17000AF0 RID: 2800
		// (get) Token: 0x06003752 RID: 14162 RVA: 0x0000B1A8 File Offset: 0x000093A8
		[Token(Token = "0x17000AF0")]
		private bool IsSkull
		{
			[Token(Token = "0x6003752")]
			[Address(RVA = "0x8740", Offset = "0x8740", VA = "0x8740")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003753 RID: 14163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003753")]
		[Address(RVA = "0x8741", Offset = "0x8741", VA = "0x8741")]
		private void Awake()
		{
		}

		// Token: 0x06003754 RID: 14164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003754")]
		[Address(RVA = "0x8742", Offset = "0x8742", VA = "0x8742")]
		public void Init(Vector3 position, bool isMyTurn)
		{
		}

		// Token: 0x06003755 RID: 14165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003755")]
		[Address(RVA = "0x8743", Offset = "0x8743", VA = "0x8743", Slot = "6")]
		public void Show()
		{
		}

		// Token: 0x06003756 RID: 14166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003756")]
		[Address(RVA = "0x8744", Offset = "0x8744", VA = "0x8744", Slot = "7")]
		public void Hide()
		{
		}

		// Token: 0x06003757 RID: 14167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003757")]
		[Address(RVA = "0x8745", Offset = "0x8745", VA = "0x8745", Slot = "8")]
		public void Play(bool _)
		{
		}

		// Token: 0x06003758 RID: 14168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003758")]
		[Address(RVA = "0x8746", Offset = "0x8746", VA = "0x8746", Slot = "12")]
		public void Dispose()
		{
		}

		// Token: 0x06003759 RID: 14169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003759")]
		[Address(RVA = "0x8747", Offset = "0x8747", VA = "0x8747")]
		public void SetSkin(Sprite skin, Sprite glow)
		{
		}

		// Token: 0x0600375A RID: 14170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600375A")]
		[Address(RVA = "0x8748", Offset = "0x8748", VA = "0x8748")]
		public void SetCount(long count)
		{
		}

		// Token: 0x0600375B RID: 14171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600375B")]
		[Address(RVA = "0x8749", Offset = "0x8749", VA = "0x8749", Slot = "17")]
		public void Release()
		{
		}

		// Token: 0x0600375C RID: 14172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600375C")]
		[Address(RVA = "0x874A", Offset = "0x874A", VA = "0x874A")]
		private void Play()
		{
		}

		// Token: 0x0600375D RID: 14173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600375D")]
		[Address(RVA = "0x874B", Offset = "0x874B", VA = "0x874B")]
		private void ResetAll()
		{
		}

		// Token: 0x0600375E RID: 14174 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600375E")]
		[Address(RVA = "0x874C", Offset = "0x874C", VA = "0x874C")]
		private IEnumerator PlayCor()
		{
			return null;
		}

		// Token: 0x0600375F RID: 14175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600375F")]
		[Address(RVA = "0x874D", Offset = "0x874D", VA = "0x874D")]
		private void GetTargets(out Transform target, out Transform animationTarget)
		{
		}

		// Token: 0x06003760 RID: 14176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003760")]
		[Address(RVA = "0x874E", Offset = "0x874E", VA = "0x874E")]
		private void FadeAnimation(bool enable, float duration)
		{
		}

		// Token: 0x06003761 RID: 14177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003761")]
		[Address(RVA = "0x874F", Offset = "0x874F", VA = "0x874F")]
		private void SetAnimationEnabled(ISkeletonGraphicProvider uiAnimation, bool enable)
		{
		}

		// Token: 0x06003762 RID: 14178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003762")]
		[Address(RVA = "0x8750", Offset = "0x8750", VA = "0x8750")]
		private void SetAlpha(float value)
		{
		}

		// Token: 0x06003763 RID: 14179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003763")]
		[Address(RVA = "0x8751", Offset = "0x8751", VA = "0x8751")]
		public void TestPlay()
		{
		}

		// Token: 0x06003764 RID: 14180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003764")]
		[Address(RVA = "0x8752", Offset = "0x8752", VA = "0x8752")]
		public StoneDestroyElement()
		{
		}

		// Token: 0x04001E6A RID: 7786
		[Token(Token = "0x4001E6A")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private StonesTypes _stone;

		// Token: 0x04001E6B RID: 7787
		[Token(Token = "0x4001E6B")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private bool _flipForRight;

		// Token: 0x04001E6C RID: 7788
		[Token(Token = "0x4001E6C")]
		[FieldOffset(Offset = "0x15")]
		[SerializeField]
		private bool _scaleToTarget;

		// Token: 0x04001E6D RID: 7789
		[Token(Token = "0x4001E6D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _skin;

		// Token: 0x04001E6E RID: 7790
		[Token(Token = "0x4001E6E")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Image _glow;

		// Token: 0x04001E6F RID: 7791
		[Token(Token = "0x4001E6F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameSpineUiAnimation _back;

		// Token: 0x04001E70 RID: 7792
		[Token(Token = "0x4001E70")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private GameSpineUiAnimation _animation;

		// Token: 0x04001E71 RID: 7793
		[Token(Token = "0x4001E71")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameSpineUiAnimation _finish;

		// Token: 0x04001E72 RID: 7794
		[Token(Token = "0x4001E72")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Transform _backTransform;

		// Token: 0x04001E73 RID: 7795
		[Token(Token = "0x4001E73")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _animationTransform;

		// Token: 0x04001E74 RID: 7796
		[Token(Token = "0x4001E74")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Transform _finishTransform;

		// Token: 0x04001E75 RID: 7797
		[Token(Token = "0x4001E75")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _myAnimationTarget;

		// Token: 0x04001E76 RID: 7798
		[Token(Token = "0x4001E76")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Transform _enemyAnimationTarget;

		// Token: 0x04001E77 RID: 7799
		[Token(Token = "0x4001E77")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform _myFinishTarget;

		// Token: 0x04001E78 RID: 7800
		[Token(Token = "0x4001E78")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private Transform _enemyFinishTarget;

		// Token: 0x04001E79 RID: 7801
		[Token(Token = "0x4001E79")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private PetViewV2 _myPet;

		// Token: 0x04001E7A RID: 7802
		[Token(Token = "0x4001E7A")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private PetViewV2 _enemyPet;

		// Token: 0x04001E7B RID: 7803
		[Token(Token = "0x4001E7B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform _myPetAnimationTarget;

		// Token: 0x04001E7C RID: 7804
		[Token(Token = "0x4001E7C")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private Transform _enemyPetAnimationTarget;

		// Token: 0x04001E7D RID: 7805
		[Token(Token = "0x4001E7D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform _myPetFinishTarget;

		// Token: 0x04001E7E RID: 7806
		[Token(Token = "0x4001E7E")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private Transform _enemyPetFinishTarget;

		// Token: 0x04001E7F RID: 7807
		[Token(Token = "0x4001E7F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _delay;

		// Token: 0x04001E80 RID: 7808
		[Token(Token = "0x4001E80")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float _flyDelay;

		// Token: 0x04001E81 RID: 7809
		[Token(Token = "0x4001E81")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _flyDuration;

		// Token: 0x04001E82 RID: 7810
		[Token(Token = "0x4001E82")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float _animationHideDuration;

		// Token: 0x04001E83 RID: 7811
		[Token(Token = "0x4001E83")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float _finishDuration;

		// Token: 0x04001E84 RID: 7812
		[Token(Token = "0x4001E84")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private Ease _scaleEasing;

		// Token: 0x04001E85 RID: 7813
		[Token(Token = "0x4001E85")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Ease _xEasing;

		// Token: 0x04001E86 RID: 7814
		[Token(Token = "0x4001E86")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private Ease _yEasing;

		// Token: 0x04001E8B RID: 7819
		[Token(Token = "0x4001E8B")]
		[FieldOffset(Offset = "0x90")]
		private Coroutine _playCor;

		// Token: 0x04001E8C RID: 7820
		[Token(Token = "0x4001E8C")]
		[FieldOffset(Offset = "0x94")]
		private Vector3 _position;

		// Token: 0x04001E8D RID: 7821
		[Token(Token = "0x4001E8D")]
		[FieldOffset(Offset = "0xA0")]
		private long _count;

		// Token: 0x04001E8E RID: 7822
		[Token(Token = "0x4001E8E")]
		[FieldOffset(Offset = "0xA8")]
		private ObjectPool<StoneDestroyElement> _pool;
	}
}
