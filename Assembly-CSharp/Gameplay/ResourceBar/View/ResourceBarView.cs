using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DefaultNamespace;
using Gameplay.ResourceBar.Control;
using Gameplay.ResourceBar.Events;
using Gameplay.ResourceBar.Model;
using Gameplay.UserInterface.View;
using Il2CppDummyDll;
using Protocol.Consts;
using UI.UIController;
using UnityEngine;

namespace Gameplay.ResourceBar.View
{
	// Token: 0x02000552 RID: 1362
	[Token(Token = "0x2000552")]
	[RequireComponent(typeof(ShowHideUIElementByRestrictions))]
	public class ResourceBarView : MonoBehaviour
	{
		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x060020BF RID: 8383 RVA: 0x000069A8 File Offset: 0x00004BA8
		[Token(Token = "0x170005FD")]
		public ResourceBarColor DefaultColor
		{
			[Token(Token = "0x60020BF")]
			[Address(RVA = "0x7222", Offset = "0x7222", VA = "0x7222")]
			get
			{
				return ResourceBarColor.Default;
			}
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x060020C0 RID: 8384 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005FE")]
		public ShowHideUIElementByRestrictions UIElementByRestrictions
		{
			[Token(Token = "0x60020C0")]
			[Address(RVA = "0x7223", Offset = "0x7223", VA = "0x7223")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x060020C1 RID: 8385 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005FF")]
		public Dictionary<Protocol.Consts.Resources, ResourceBarItemView> ItemsDictionary
		{
			[Token(Token = "0x60020C1")]
			[Address(RVA = "0x7224", Offset = "0x7224", VA = "0x7224")]
			get
			{
				return null;
			}
		}

		// Token: 0x1400013E RID: 318
		// (add) Token: 0x060020C2 RID: 8386 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060020C3 RID: 8387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400013E")]
		public event Action<Protocol.Consts.Resources> ClickOnResourceViewEvent
		{
			[Token(Token = "0x60020C2")]
			[Address(RVA = "0x7225", Offset = "0x7225", VA = "0x7225")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60020C3")]
			[Address(RVA = "0x7226", Offset = "0x7226", VA = "0x7226")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400013F RID: 319
		// (add) Token: 0x060020C4 RID: 8388 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060020C5 RID: 8389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400013F")]
		public event Action<bool> GameObjectIsEnableChangedEvent
		{
			[Token(Token = "0x60020C4")]
			[Address(RVA = "0x7227", Offset = "0x7227", VA = "0x7227")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60020C5")]
			[Address(RVA = "0x7228", Offset = "0x7228", VA = "0x7228")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x060020C6 RID: 8390 RVA: 0x000069C0 File Offset: 0x00004BC0
		// (set) Token: 0x060020C7 RID: 8391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000600")]
		public bool IsInteractive
		{
			[Token(Token = "0x60020C6")]
			[Address(RVA = "0x7229", Offset = "0x7229", VA = "0x7229")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60020C7")]
			[Address(RVA = "0x722A", Offset = "0x722A", VA = "0x722A")]
			set
			{
			}
		}

		// Token: 0x060020C8 RID: 8392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020C8")]
		[Address(RVA = "0x722B", Offset = "0x722B", VA = "0x722B")]
		private void OnDestroy()
		{
		}

		// Token: 0x060020C9 RID: 8393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020C9")]
		[Address(RVA = "0x722C", Offset = "0x722C", VA = "0x722C")]
		private void Awake()
		{
		}

		// Token: 0x060020CA RID: 8394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020CA")]
		[Address(RVA = "0x722D", Offset = "0x722D", VA = "0x722D")]
		private void OnEnable()
		{
		}

		// Token: 0x060020CB RID: 8395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020CB")]
		[Address(RVA = "0x722E", Offset = "0x722E", VA = "0x722E")]
		private void OnDisable()
		{
		}

		// Token: 0x060020CC RID: 8396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020CC")]
		[Address(RVA = "0x722F", Offset = "0x722F", VA = "0x722F")]
		private void OnClickEvent(Protocol.Consts.Resources resourceId)
		{
		}

		// Token: 0x060020CD RID: 8397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020CD")]
		[Address(RVA = "0x7230", Offset = "0x7230", VA = "0x7230")]
		private void DestroyMVC()
		{
		}

		// Token: 0x060020CE RID: 8398 RVA: 0x000069D8 File Offset: 0x00004BD8
		[Token(Token = "0x60020CE")]
		[Address(RVA = "0x7231", Offset = "0x7231", VA = "0x7231")]
		private bool TrySetupMVC()
		{
			return default(bool);
		}

		// Token: 0x060020CF RID: 8399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020CF")]
		[Address(RVA = "0x7232", Offset = "0x7232", VA = "0x7232")]
		public void ResetInitialize()
		{
		}

		// Token: 0x060020D0 RID: 8400 RVA: 0x000069F0 File Offset: 0x00004BF0
		[Token(Token = "0x60020D0")]
		[Address(RVA = "0x7233", Offset = "0x7233", VA = "0x7233")]
		public bool TryGetResourceBarItemView(Protocol.Consts.Resources resource, out ResourceBarItemView view)
		{
			return default(bool);
		}

		// Token: 0x060020D1 RID: 8401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020D1")]
		[Address(RVA = "0x7234", Offset = "0x7234", VA = "0x7234")]
		public void SetColor(in ResourceBarColor resourceBarColor)
		{
		}

		// Token: 0x060020D2 RID: 8402 RVA: 0x00006A08 File Offset: 0x00004C08
		[Token(Token = "0x60020D2")]
		[Address(RVA = "0x7235", Offset = "0x7235", VA = "0x7235")]
		public bool GetIsActiveState(IList<Scenes> scenes, bool expectedActive)
		{
			return default(bool);
		}

		// Token: 0x060020D3 RID: 8403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020D3")]
		[Address(RVA = "0x7236", Offset = "0x7236", VA = "0x7236")]
		public ResourceBarView()
		{
		}

		// Token: 0x040011E4 RID: 4580
		[Token(Token = "0x40011E4")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private ResourceBarItemView[] _items;

		// Token: 0x040011E5 RID: 4581
		[Token(Token = "0x40011E5")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private ResourceBarColorSO _resourceBarColors;

		// Token: 0x040011E6 RID: 4582
		[Token(Token = "0x40011E6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ResourceBarColor _defaultColor;

		// Token: 0x040011E7 RID: 4583
		[Token(Token = "0x40011E7")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private ResourceBarView.ActivStateByScene _activeStateByScene;

		// Token: 0x040011E8 RID: 4584
		[Token(Token = "0x40011E8")]
		[FieldOffset(Offset = "0x24")]
		private readonly Dictionary<Protocol.Consts.Resources, ResourceBarItemView> _itemsDictionary;

		// Token: 0x040011EB RID: 4587
		[Token(Token = "0x40011EB")]
		[FieldOffset(Offset = "0x30")]
		private ResourceBarEvents _events;

		// Token: 0x040011EC RID: 4588
		[Token(Token = "0x40011EC")]
		[FieldOffset(Offset = "0x34")]
		private ResourceBarModel _model;

		// Token: 0x040011ED RID: 4589
		[Token(Token = "0x40011ED")]
		[FieldOffset(Offset = "0x38")]
		private ResourceBarController _controller;

		// Token: 0x040011EE RID: 4590
		[Token(Token = "0x40011EE")]
		[FieldOffset(Offset = "0x3C")]
		private ResourceBarViewMediator _mediator;

		// Token: 0x040011EF RID: 4591
		[Token(Token = "0x40011EF")]
		[FieldOffset(Offset = "0x40")]
		private bool _isInitialized;

		// Token: 0x040011F0 RID: 4592
		[Token(Token = "0x40011F0")]
		[FieldOffset(Offset = "0x41")]
		private bool _isInteractive;

		// Token: 0x02000553 RID: 1363
		[Token(Token = "0x2000553")]
		[Serializable]
		internal struct ActivStateByScene
		{
			// Token: 0x17000601 RID: 1537
			// (get) Token: 0x060020D4 RID: 8404 RVA: 0x00006A20 File Offset: 0x00004C20
			[Token(Token = "0x17000601")]
			public Scenes Scene
			{
				[Token(Token = "0x60020D4")]
				[Address(RVA = "0x7237", Offset = "0x7237", VA = "0x7237")]
				get
				{
					return Scenes.Preloader;
				}
			}

			// Token: 0x17000602 RID: 1538
			// (get) Token: 0x060020D5 RID: 8405 RVA: 0x00006A38 File Offset: 0x00004C38
			[Token(Token = "0x17000602")]
			public bool IsActive
			{
				[Token(Token = "0x60020D5")]
				[Address(RVA = "0x7238", Offset = "0x7238", VA = "0x7238")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x040011F1 RID: 4593
			[Token(Token = "0x40011F1")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			private Scenes _scene;

			// Token: 0x040011F2 RID: 4594
			[Token(Token = "0x40011F2")]
			[FieldOffset(Offset = "0x4")]
			[SerializeField]
			private bool _isActive;
		}
	}
}
