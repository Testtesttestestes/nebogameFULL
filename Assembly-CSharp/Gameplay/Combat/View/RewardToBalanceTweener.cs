using System;
using System.Collections;
using System.Collections.Generic;
using AssetContent;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Gameplay.Combat.Model;
using Il2CppDummyDll;
using Protocol.Consts;
using TMPro;
using UI.Rewards;
using UnityEngine;

namespace Gameplay.Combat.View
{
	// Token: 0x02000924 RID: 2340
	[Token(Token = "0x2000924")]
	[AddComponentMenu("Combat/RewardToBalanceTweener")]
	public class RewardToBalanceTweener : MonoBehaviour
	{
		// Token: 0x17000AE5 RID: 2789
		// (get) Token: 0x06003728 RID: 14120 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000AE5")]
		public RewardToBalanceTweener.Balance Ballance
		{
			[Token(Token = "0x6003728")]
			[Address(RVA = "0x8717", Offset = "0x8717", VA = "0x8717")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003729 RID: 14121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003729")]
		[Address(RVA = "0x8718", Offset = "0x8718", VA = "0x8718")]
		public void Play(PlayerProfitData playerProfit, float delay)
		{
		}

		// Token: 0x0600372A RID: 14122 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600372A")]
		[Address(RVA = "0x8719", Offset = "0x8719", VA = "0x8719")]
		private IEnumerator PlayRoutine(PlayerProfitData playerProfit, float delay)
		{
			return null;
		}

		// Token: 0x0600372B RID: 14123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600372B")]
		[Address(RVA = "0x871A", Offset = "0x871A", VA = "0x871A")]
		private void Play_internal(PlayerProfitData playerProfit)
		{
		}

		// Token: 0x0600372C RID: 14124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600372C")]
		[Address(RVA = "0x871B", Offset = "0x871B", VA = "0x871B")]
		private void StartAnimation(Transform movable, float duration)
		{
		}

		// Token: 0x0600372D RID: 14125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600372D")]
		[Address(RVA = "0x871C", Offset = "0x871C", VA = "0x871C")]
		private void OnAnimationEnd()
		{
		}

		// Token: 0x0600372E RID: 14126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600372E")]
		[Address(RVA = "0x871D", Offset = "0x871D", VA = "0x871D")]
		private void ModifyPosition(float t)
		{
		}

		// Token: 0x0600372F RID: 14127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600372F")]
		[Address(RVA = "0x871E", Offset = "0x871E", VA = "0x871E")]
		public void Test(float pointsValue = float.NaN)
		{
		}

		// Token: 0x06003730 RID: 14128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003730")]
		[Address(RVA = "0x871F", Offset = "0x871F", VA = "0x871F")]
		public RewardToBalanceTweener()
		{
		}

		// Token: 0x04001E45 RID: 7749
		[Token(Token = "0x4001E45")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private RewardsRender _rewardsBox;

		// Token: 0x04001E46 RID: 7750
		[Token(Token = "0x4001E46")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private RewardToBalanceTweener.Balance _ballance;

		// Token: 0x04001E47 RID: 7751
		[Token(Token = "0x4001E47")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _layer;

		// Token: 0x04001E48 RID: 7752
		[Token(Token = "0x4001E48")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Transform _target;

		// Token: 0x04001E49 RID: 7753
		[Token(Token = "0x4001E49")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ParticleSystem _particleSystem;

		// Token: 0x04001E4A RID: 7754
		[Token(Token = "0x4001E4A")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private List<RewardToBalanceTweener.DurationCfg> _addtionsDiuration;

		// Token: 0x04001E4B RID: 7755
		[Token(Token = "0x4001E4B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RewardTypes _targetReward;

		// Token: 0x04001E4C RID: 7756
		[Token(Token = "0x4001E4C")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _curve;

		// Token: 0x04001E4D RID: 7757
		[Token(Token = "0x4001E4D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Ease _flyEase;

		// Token: 0x04001E4E RID: 7758
		[Token(Token = "0x4001E4E")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _flyoTargetDuration;

		// Token: 0x04001E4F RID: 7759
		[Token(Token = "0x4001E4F")]
		[FieldOffset(Offset = "0x38")]
		private float _t;

		// Token: 0x04001E50 RID: 7760
		[Token(Token = "0x4001E50")]
		[FieldOffset(Offset = "0x3C")]
		private Transform _movable;

		// Token: 0x04001E51 RID: 7761
		[Token(Token = "0x4001E51")]
		[FieldOffset(Offset = "0x40")]
		private RewardToBalanceTweener.BezierCurve _bezierCurve;

		// Token: 0x04001E52 RID: 7762
		[Token(Token = "0x4001E52")]
		[FieldOffset(Offset = "0x64")]
		private ParticleSystem _ps;

		// Token: 0x04001E53 RID: 7763
		[Token(Token = "0x4001E53")]
		[FieldOffset(Offset = "0x68")]
		private RewardToBalanceTweener.DurationCfg _durationCfg;

		// Token: 0x04001E54 RID: 7764
		[Token(Token = "0x4001E54")]
		[FieldOffset(Offset = "0x6C")]
		private PlayerProfitData _playerProfit;

		// Token: 0x04001E55 RID: 7765
		[Token(Token = "0x4001E55")]
		[FieldOffset(Offset = "0x70")]
		private long _pointToAdd;

		// Token: 0x04001E56 RID: 7766
		[Token(Token = "0x4001E56")]
		[FieldOffset(Offset = "0x78")]
		private TweenerCore<float, float, FloatOptions> _flyTween;

		// Token: 0x02000925 RID: 2341
		[Token(Token = "0x2000925")]
		[Serializable]
		public class Balance
		{
			// Token: 0x17000AE6 RID: 2790
			// (get) Token: 0x06003734 RID: 14132 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000AE6")]
			public GameRawImage Icon
			{
				[Token(Token = "0x6003734")]
				[Address(RVA = "0x8723", Offset = "0x8723", VA = "0x8723")]
				get
				{
					return null;
				}
			}

			// Token: 0x06003735 RID: 14133 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003735")]
			[Address(RVA = "0x1BEA", Offset = "0x1BEA", VA = "0x1BEA")]
			public void SetValue(float value)
			{
			}

			// Token: 0x06003736 RID: 14134 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003736")]
			[Address(RVA = "0x8724", Offset = "0x8724", VA = "0x8724")]
			public void SetValue(float value, float duration)
			{
			}

			// Token: 0x06003737 RID: 14135 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003737")]
			[Address(RVA = "0x8725", Offset = "0x8725", VA = "0x8725")]
			public void Add(float value, float duration)
			{
			}

			// Token: 0x06003738 RID: 14136 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003738")]
			[Address(RVA = "0x8726", Offset = "0x8726", VA = "0x8726")]
			public Balance()
			{
			}

			// Token: 0x04001E57 RID: 7767
			[Token(Token = "0x4001E57")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			private TextMeshProUGUI _valueTextField;

			// Token: 0x04001E58 RID: 7768
			[Token(Token = "0x4001E58")]
			[FieldOffset(Offset = "0xC")]
			[SerializeField]
			private GameRawImage _icon;

			// Token: 0x04001E59 RID: 7769
			[Token(Token = "0x4001E59")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private Ease _easeForAdditionValue;

			// Token: 0x04001E5A RID: 7770
			[Token(Token = "0x4001E5A")]
			[FieldOffset(Offset = "0x14")]
			private float _value;

			// Token: 0x04001E5B RID: 7771
			[Token(Token = "0x4001E5B")]
			[FieldOffset(Offset = "0x18")]
			private Tweener _addTween;
		}

		// Token: 0x02000927 RID: 2343
		[Token(Token = "0x2000927")]
		private readonly struct BezierCurve
		{
			// Token: 0x0600373B RID: 14139 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600373B")]
			[Address(RVA = "0x8729", Offset = "0x8729", VA = "0x8729")]
			public BezierCurve(Vector3 a, Vector3 b, Vector3 c)
			{
			}

			// Token: 0x0600373C RID: 14140 RVA: 0x0000B0E8 File Offset: 0x000092E8
			[Token(Token = "0x600373C")]
			[Address(RVA = "0x872A", Offset = "0x872A", VA = "0x872A")]
			public Vector3 GetPosition(float t)
			{
				return default(Vector3);
			}

			// Token: 0x04001E5F RID: 7775
			[Token(Token = "0x4001E5F")]
			[FieldOffset(Offset = "0x0")]
			public readonly Vector3 A;

			// Token: 0x04001E60 RID: 7776
			[Token(Token = "0x4001E60")]
			[FieldOffset(Offset = "0xC")]
			public readonly Vector3 B;

			// Token: 0x04001E61 RID: 7777
			[Token(Token = "0x4001E61")]
			[FieldOffset(Offset = "0x18")]
			public readonly Vector3 C;
		}

		// Token: 0x02000928 RID: 2344
		[Token(Token = "0x2000928")]
		[Serializable]
		public class DurationCfg
		{
			// Token: 0x0600373D RID: 14141 RVA: 0x0000B100 File Offset: 0x00009300
			[Token(Token = "0x600373D")]
			[Address(RVA = "0x872B", Offset = "0x872B", VA = "0x872B")]
			public bool IsFit(float value)
			{
				return default(bool);
			}

			// Token: 0x17000AE7 RID: 2791
			// (get) Token: 0x0600373E RID: 14142 RVA: 0x0000B118 File Offset: 0x00009318
			[Token(Token = "0x17000AE7")]
			public float DurationForAddition
			{
				[Token(Token = "0x600373E")]
				[Address(RVA = "0x872C", Offset = "0x872C", VA = "0x872C")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x0600373F RID: 14143 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600373F")]
			[Address(RVA = "0x872D", Offset = "0x872D", VA = "0x872D")]
			public DurationCfg()
			{
			}

			// Token: 0x04001E62 RID: 7778
			[Token(Token = "0x4001E62")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			private float _from;

			// Token: 0x04001E63 RID: 7779
			[Token(Token = "0x4001E63")]
			[FieldOffset(Offset = "0xC")]
			[SerializeField]
			private float _to;

			// Token: 0x04001E64 RID: 7780
			[Token(Token = "0x4001E64")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private float durationForAddition;
		}
	}
}
