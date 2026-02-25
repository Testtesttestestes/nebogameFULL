using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

namespace Gameplay.Input
{
	// Token: 0x020006F3 RID: 1779
	[Token(Token = "0x20006F3")]
	public class PlayerInputController : MonoBehaviour, IPlayerInput
	{
		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x06002A9D RID: 10909 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000816")]
		public Pointer CurrentPointer
		{
			[Token(Token = "0x6002A9D")]
			[Address(RVA = "0x7B38", Offset = "0x7B38", VA = "0x7B38", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000817 RID: 2071
		// (get) Token: 0x06002A9E RID: 10910 RVA: 0x00008610 File Offset: 0x00006810
		// (set) Token: 0x06002A9F RID: 10911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000817")]
		public bool IsPressed
		{
			[Token(Token = "0x6002A9E")]
			[Address(RVA = "0x7B39", Offset = "0x7B39", VA = "0x7B39", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002A9F")]
			[Address(RVA = "0x7B3A", Offset = "0x7B3A", VA = "0x7B3A")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1400015A RID: 346
		// (add) Token: 0x06002AA0 RID: 10912 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06002AA1 RID: 10913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400015A")]
		public event Action<IPlayerInput, InputAction.CallbackContext> PressEndedEvent
		{
			[Token(Token = "0x6002AA0")]
			[Address(RVA = "0x7B3B", Offset = "0x7B3B", VA = "0x7B3B", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002AA1")]
			[Address(RVA = "0x7B3C", Offset = "0x7B3C", VA = "0x7B3C", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400015B RID: 347
		// (add) Token: 0x06002AA2 RID: 10914 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06002AA3 RID: 10915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400015B")]
		public event Action<IPlayerInput, InputAction.CallbackContext> PressStartEvent
		{
			[Token(Token = "0x6002AA2")]
			[Address(RVA = "0x7B3D", Offset = "0x7B3D", VA = "0x7B3D", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002AA3")]
			[Address(RVA = "0x7B3E", Offset = "0x7B3E", VA = "0x7B3E", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06002AA4 RID: 10916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AA4")]
		[Address(RVA = "0x7B3F", Offset = "0x7B3F", VA = "0x7B3F")]
		private void Start()
		{
		}

		// Token: 0x06002AA5 RID: 10917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AA5")]
		[Address(RVA = "0x7B40", Offset = "0x7B40", VA = "0x7B40")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002AA6 RID: 10918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AA6")]
		[Address(RVA = "0x7B41", Offset = "0x7B41", VA = "0x7B41")]
		private void OnEnable()
		{
		}

		// Token: 0x06002AA7 RID: 10919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AA7")]
		[Address(RVA = "0x7B42", Offset = "0x7B42", VA = "0x7B42")]
		private void OnDisable()
		{
		}

		// Token: 0x06002AA8 RID: 10920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AA8")]
		[Address(RVA = "0x7B43", Offset = "0x7B43", VA = "0x7B43")]
		private void PressEndedEventHandler(InputAction.CallbackContext ctx)
		{
		}

		// Token: 0x06002AA9 RID: 10921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AA9")]
		[Address(RVA = "0x7B44", Offset = "0x7B44", VA = "0x7B44")]
		private void PressStartedEventHandler(InputAction.CallbackContext ctx)
		{
		}

		// Token: 0x06002AAA RID: 10922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AAA")]
		[Address(RVA = "0x7B45", Offset = "0x7B45", VA = "0x7B45")]
		public PlayerInputController()
		{
		}

		// Token: 0x04001741 RID: 5953
		[Token(Token = "0x4001741")]
		private const string PRESS_ACTION = "Press";

		// Token: 0x04001742 RID: 5954
		[Token(Token = "0x4001742")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private InputActionAsset _actionsAsset;

		// Token: 0x04001743 RID: 5955
		[Token(Token = "0x4001743")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private LayerMask _layerMask;

		// Token: 0x04001744 RID: 5956
		[Token(Token = "0x4001744")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private EventSystem _eventSystem;

		// Token: 0x04001745 RID: 5957
		[Token(Token = "0x4001745")]
		[FieldOffset(Offset = "0x1C")]
		private InputAction _clickAction;

		// Token: 0x04001746 RID: 5958
		[Token(Token = "0x4001746")]
		[FieldOffset(Offset = "0x20")]
		private readonly List<RaycastResult> _raycastResults;
	}
}
