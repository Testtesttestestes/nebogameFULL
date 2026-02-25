using System;
using Gameplay.Input;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.InputSystem;

namespace UI.Activation
{
	// Token: 0x0200025A RID: 602
	[Token(Token = "0x200025A")]
	public class DeActivateWhenInputAnyWay : MonoBehaviour
	{
		// Token: 0x06000E88 RID: 3720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E88")]
		[Address(RVA = "0x6109", Offset = "0x6109", VA = "0x6109")]
		private void Awake()
		{
		}

		// Token: 0x06000E89 RID: 3721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E89")]
		[Address(RVA = "0x610A", Offset = "0x610A", VA = "0x610A")]
		private void OnEnable()
		{
		}

		// Token: 0x06000E8A RID: 3722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E8A")]
		[Address(RVA = "0x610B", Offset = "0x610B", VA = "0x610B")]
		private void OnDisable()
		{
		}

		// Token: 0x06000E8B RID: 3723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E8B")]
		[Address(RVA = "0x610C", Offset = "0x610C", VA = "0x610C")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000E8C RID: 3724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E8C")]
		[Address(RVA = "0x610D", Offset = "0x610D", VA = "0x610D")]
		private void PlayerInputControllerOnPressStartedEvent(IPlayerInput input, InputAction.CallbackContext context)
		{
		}

		// Token: 0x06000E8D RID: 3725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E8D")]
		[Address(RVA = "0x610E", Offset = "0x610E", VA = "0x610E")]
		public DeActivateWhenInputAnyWay()
		{
		}

		// Token: 0x0400074E RID: 1870
		[Token(Token = "0x400074E")]
		[FieldOffset(Offset = "0x10")]
		private IPlayerInput _playerInputController;
	}
}
