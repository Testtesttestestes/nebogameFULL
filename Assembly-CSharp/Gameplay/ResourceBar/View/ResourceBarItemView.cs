using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Gameplay.Accounts.Model.Data;
using Gameplay.User.Model;
using Il2CppDummyDll;
using Protocol.Consts;
using Protocol.Dic;
using UI.ToolTip;
using UI.ToolTip.Implementations;
using UnityEngine;
using UnityEngine.EventSystems;
using Utils.Cache;

namespace Gameplay.ResourceBar.View
{
	// Token: 0x0200054F RID: 1359
	[Token(Token = "0x200054F")]
	public class ResourceBarItemView : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler, IToolTipDataProvider
	{
		// Token: 0x1400013D RID: 317
		// (add) Token: 0x0600209D RID: 8349 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600209E RID: 8350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400013D")]
		public event Action<Protocol.Consts.Resources> ClickEvent
		{
			[Token(Token = "0x600209D")]
			[Address(RVA = "0x7202", Offset = "0x7202", VA = "0x7202")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600209E")]
			[Address(RVA = "0x7203", Offset = "0x7203", VA = "0x7203")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x0600209F RID: 8351 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005F7")]
		public ResourceBarIconValueView IconValueView
		{
			[Token(Token = "0x600209F")]
			[Address(RVA = "0x7204", Offset = "0x7204", VA = "0x7204")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x060020A0 RID: 8352 RVA: 0x00006978 File Offset: 0x00004B78
		// (set) Token: 0x060020A1 RID: 8353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005F8")]
		public bool IsInteractive
		{
			[Token(Token = "0x60020A0")]
			[Address(RVA = "0x7205", Offset = "0x7205", VA = "0x7205")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60020A1")]
			[Address(RVA = "0x7206", Offset = "0x7206", VA = "0x7206")]
			set
			{
			}
		}

		// Token: 0x060020A2 RID: 8354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020A2")]
		[Address(RVA = "0x7207", Offset = "0x7207", VA = "0x7207")]
		private void Awake()
		{
		}

		// Token: 0x060020A3 RID: 8355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020A3")]
		[Address(RVA = "0x7208", Offset = "0x7208", VA = "0x7208")]
		private void ResetPoolObjectDelegate(ResourceBarDeltaView pooledObject)
		{
		}

		// Token: 0x060020A4 RID: 8356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020A4")]
		[Address(RVA = "0x7209", Offset = "0x7209", VA = "0x7209")]
		public void Init(UserModel userModel, TradeAccount tradeAccount, ResourcesDic resourcesDict)
		{
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x060020A5 RID: 8357 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060020A6 RID: 8358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005F9")]
		public UserModel UserModel
		{
			[Token(Token = "0x60020A5")]
			[Address(RVA = "0x720A", Offset = "0x720A", VA = "0x720A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60020A6")]
			[Address(RVA = "0x720B", Offset = "0x720B", VA = "0x720B")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x060020A7 RID: 8359 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060020A8 RID: 8360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005FA")]
		public TradeAccount TradeAccount
		{
			[Token(Token = "0x60020A7")]
			[Address(RVA = "0x720C", Offset = "0x720C", VA = "0x720C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60020A8")]
			[Address(RVA = "0x720D", Offset = "0x720D", VA = "0x720D")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x060020A9 RID: 8361 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060020AA RID: 8362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005FB")]
		public ResourcesDic ResourcesDic
		{
			[Token(Token = "0x60020A9")]
			[Address(RVA = "0x720E", Offset = "0x720E", VA = "0x720E")]
			get
			{
				return null;
			}
			[Token(Token = "0x60020AA")]
			[Address(RVA = "0x720F", Offset = "0x720F", VA = "0x720F")]
			private set
			{
			}
		}

		// Token: 0x060020AB RID: 8363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020AB")]
		[Address(RVA = "0x7210", Offset = "0x7210", VA = "0x7210")]
		private void HandleResourcesDicChanged()
		{
		}

		// Token: 0x060020AC RID: 8364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020AC")]
		[Address(RVA = "0x7211", Offset = "0x7211", VA = "0x7211")]
		private void OnDestroy()
		{
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x060020AD RID: 8365 RVA: 0x00006990 File Offset: 0x00004B90
		// (set) Token: 0x060020AE RID: 8366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005FC")]
		public double Value
		{
			[Token(Token = "0x60020AD")]
			[Address(RVA = "0x7212", Offset = "0x7212", VA = "0x7212")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x60020AE")]
			[Address(RVA = "0x7213", Offset = "0x7213", VA = "0x7213")]
			set
			{
			}
		}

		// Token: 0x060020AF RID: 8367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020AF")]
		[Address(RVA = "0x7214", Offset = "0x7214", VA = "0x7214", Slot = "4")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x060020B0 RID: 8368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020B0")]
		[Address(RVA = "0x7215", Offset = "0x7215", VA = "0x7215", Slot = "5")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		// Token: 0x060020B1 RID: 8369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020B1")]
		[Address(RVA = "0x7216", Offset = "0x7216", VA = "0x7216", Slot = "6")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		// Token: 0x060020B2 RID: 8370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020B2")]
		[Address(RVA = "0x7217", Offset = "0x7217", VA = "0x7217")]
		public void ShowDeltaAnimation(double delta, double targetAmount)
		{
		}

		// Token: 0x060020B3 RID: 8371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020B3")]
		[Address(RVA = "0x1CCF", Offset = "0x1CCF", VA = "0x1CCF")]
		public void DisposeAllDeltaAnimation()
		{
		}

		// Token: 0x060020B4 RID: 8372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020B4")]
		[Address(RVA = "0x1CD4", Offset = "0x1CD4", VA = "0x1CD4")]
		private void HandleQueue()
		{
		}

		// Token: 0x060020B5 RID: 8373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020B5")]
		[Address(RVA = "0x7218", Offset = "0x7218", VA = "0x7218")]
		private void OnFirstDeltaAnimationStart()
		{
		}

		// Token: 0x060020B6 RID: 8374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020B6")]
		[Address(RVA = "0x7219", Offset = "0x7219", VA = "0x7219")]
		private void OnLastDeltaAnimationComplete()
		{
		}

		// Token: 0x060020B7 RID: 8375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020B7")]
		[Address(RVA = "0x721A", Offset = "0x721A", VA = "0x721A")]
		private void OnBlockComplete()
		{
		}

		// Token: 0x060020B8 RID: 8376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020B8")]
		[Address(RVA = "0x721B", Offset = "0x721B", VA = "0x721B")]
		private void CompleteCallback(ResourceBarDeltaView deltaView)
		{
		}

		// Token: 0x060020B9 RID: 8377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020B9")]
		[Address(RVA = "0x721C", Offset = "0x721C", VA = "0x721C")]
		private void ChangeValueSmooth(double newValue, float duration)
		{
		}

		// Token: 0x060020BA RID: 8378 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60020BA")]
		[Address(RVA = "0x721D", Offset = "0x721D", VA = "0x721D", Slot = "8")]
		public virtual BaseToolTipData GetData()
		{
			return null;
		}

		// Token: 0x060020BB RID: 8379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020BB")]
		[Address(RVA = "0x721E", Offset = "0x721E", VA = "0x721E")]
		public ResourceBarItemView()
		{
		}

		// Token: 0x040011CC RID: 4556
		[Token(Token = "0x40011CC")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private ResourceBarIconValueView _iconValueView;

		// Token: 0x040011CD RID: 4557
		[Token(Token = "0x40011CD")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Transform _animationContainer;

		// Token: 0x040011CE RID: 4558
		[Token(Token = "0x40011CE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ResourceBarDeltaView _deltaPrefab;

		// Token: 0x040011CF RID: 4559
		[Token(Token = "0x40011CF")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextToolTip _iconToolTip;

		// Token: 0x040011D0 RID: 4560
		[Token(Token = "0x40011D0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextToolTip _valueToolTip;

		// Token: 0x040011D1 RID: 4561
		[Token(Token = "0x40011D1")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		public Protocol.Consts.Resources Resource;

		// Token: 0x040011D2 RID: 4562
		[Token(Token = "0x40011D2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _defaultDuration;

		// Token: 0x040011D3 RID: 4563
		[Token(Token = "0x40011D3")]
		[FieldOffset(Offset = "0x2C")]
		[Tooltip("Минимальное время до следующей генерации delta view на случай очереди из нескольких показов на запрос изменения баланса")]
		[SerializeField]
		private float _minTimeBetweenGenerateDeltaView;

		// Token: 0x040011D5 RID: 4565
		[Token(Token = "0x40011D5")]
		[FieldOffset(Offset = "0x34")]
		private GameObjectPool<ResourceBarDeltaView> _deltaViewPool;

		// Token: 0x040011D6 RID: 4566
		[Token(Token = "0x40011D6")]
		[FieldOffset(Offset = "0x38")]
		private HashSet<ResourceBarDeltaView> _currentViews;

		// Token: 0x040011D7 RID: 4567
		[Token(Token = "0x40011D7")]
		[FieldOffset(Offset = "0x3C")]
		private Queue<ResourceBarItemView.ResourceDeltaData> _deltaQueue;

		// Token: 0x040011D8 RID: 4568
		[Token(Token = "0x40011D8")]
		[FieldOffset(Offset = "0x40")]
		private Tweener _changeValueSmoothTweener;

		// Token: 0x040011D9 RID: 4569
		[Token(Token = "0x40011D9")]
		[FieldOffset(Offset = "0x44")]
		private bool _isInteractive;

		// Token: 0x040011DA RID: 4570
		[Token(Token = "0x40011DA")]
		[FieldOffset(Offset = "0x48")]
		private Tween _blockTween;

		// Token: 0x040011DD RID: 4573
		[Token(Token = "0x40011DD")]
		[FieldOffset(Offset = "0x54")]
		private ResourcesDic _resourcesDic;

		// Token: 0x040011DE RID: 4574
		[Token(Token = "0x40011DE")]
		[FieldOffset(Offset = "0x58")]
		private double _value;

		// Token: 0x02000550 RID: 1360
		[Token(Token = "0x2000550")]
		public class ResourceDeltaData
		{
			// Token: 0x060020BC RID: 8380 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60020BC")]
			[Address(RVA = "0x721F", Offset = "0x721F", VA = "0x721F")]
			public ResourceDeltaData()
			{
			}

			// Token: 0x040011DF RID: 4575
			[Token(Token = "0x40011DF")]
			[FieldOffset(Offset = "0x8")]
			public double TargetAmount;

			// Token: 0x040011E0 RID: 4576
			[Token(Token = "0x40011E0")]
			[FieldOffset(Offset = "0x10")]
			public double DeltaAmount;
		}
	}
}
