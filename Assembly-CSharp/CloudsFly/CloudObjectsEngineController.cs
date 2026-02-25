using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CloudsFly.Movement;
using Il2CppDummyDll;
using UnityEngine;

namespace CloudsFly
{
	// Token: 0x020012F9 RID: 4857
	[Token(Token = "0x20012F9")]
	public class CloudObjectsEngineController : MonoBehaviour
	{
		// Token: 0x14000305 RID: 773
		// (add) Token: 0x06007393 RID: 29587 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06007394 RID: 29588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000305")]
		public event Action OnInitialized
		{
			[Token(Token = "0x6007393")]
			[Address(RVA = "0xBD7F", Offset = "0xBD7F", VA = "0xBD7F")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6007394")]
			[Address(RVA = "0xBD80", Offset = "0xBD80", VA = "0xBD80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001757 RID: 5975
		// (get) Token: 0x06007395 RID: 29589 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001757")]
		public CloudsVerticalMovementAnimation VerticalMovementAnimation
		{
			[Token(Token = "0x6007395")]
			[Address(RVA = "0xBD81", Offset = "0xBD81", VA = "0xBD81")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001758 RID: 5976
		// (get) Token: 0x06007396 RID: 29590 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001758")]
		public CloudBGParallax CloudBGParallax
		{
			[Token(Token = "0x6007396")]
			[Address(RVA = "0xBD82", Offset = "0xBD82", VA = "0xBD82")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007397 RID: 29591 RVA: 0x00014C58 File Offset: 0x00012E58
		[Token(Token = "0x6007397")]
		[Address(RVA = "0xBD83", Offset = "0xBD83", VA = "0xBD83")]
		private float GetCloudDistanceInternal()
		{
			return 0f;
		}

		// Token: 0x06007398 RID: 29592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007398")]
		[Address(RVA = "0xBD84", Offset = "0xBD84", VA = "0xBD84")]
		private void Start()
		{
		}

		// Token: 0x06007399 RID: 29593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007399")]
		[Address(RVA = "0xBD85", Offset = "0xBD85", VA = "0xBD85")]
		protected void LateUpdate()
		{
		}

		// Token: 0x0600739A RID: 29594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600739A")]
		[Address(RVA = "0xBD86", Offset = "0xBD86", VA = "0xBD86")]
		private void ResetPositions()
		{
		}

		// Token: 0x0600739B RID: 29595 RVA: 0x00014C70 File Offset: 0x00012E70
		[Token(Token = "0x600739B")]
		[Address(RVA = "0xBD87", Offset = "0xBD87", VA = "0xBD87")]
		private float GetRandomRange(float distance, float left, float right)
		{
			return 0f;
		}

		// Token: 0x0600739C RID: 29596 RVA: 0x00014C88 File Offset: 0x00012E88
		[Token(Token = "0x600739C")]
		[Address(RVA = "0xBD88", Offset = "0xBD88", VA = "0xBD88")]
		private float GetRandom(float distance)
		{
			return 0f;
		}

		// Token: 0x0600739D RID: 29597 RVA: 0x00014CA0 File Offset: 0x00012EA0
		[Token(Token = "0x600739D")]
		[Address(RVA = "0xBD89", Offset = "0xBD89", VA = "0xBD89")]
		private float GetWidthFromCameraForFar()
		{
			return 0f;
		}

		// Token: 0x0600739E RID: 29598 RVA: 0x00014CB8 File Offset: 0x00012EB8
		[Token(Token = "0x600739E")]
		[Address(RVA = "0xBD8A", Offset = "0xBD8A", VA = "0xBD8A")]
		private float GetWidthFromCamera(float distanceFromCamera)
		{
			return 0f;
		}

		// Token: 0x0600739F RID: 29599 RVA: 0x00014CD0 File Offset: 0x00012ED0
		[Token(Token = "0x600739F")]
		[Address(RVA = "0xBD8B", Offset = "0xBD8B", VA = "0xBD8B")]
		private Vector2 GetSizeFromCamera(float distanceFromCamera)
		{
			return default(Vector2);
		}

		// Token: 0x060073A0 RID: 29600 RVA: 0x00014CE8 File Offset: 0x00012EE8
		[Token(Token = "0x60073A0")]
		[Address(RVA = "0xBD8C", Offset = "0xBD8C", VA = "0xBD8C")]
		private Vector2 GetLocalSizeFromCamera(float distanceFromCamera)
		{
			return default(Vector2);
		}

		// Token: 0x060073A1 RID: 29601 RVA: 0x00014D00 File Offset: 0x00012F00
		[Token(Token = "0x60073A1")]
		[Address(RVA = "0xBD8D", Offset = "0xBD8D", VA = "0xBD8D")]
		private bool GetBlockResetPositions()
		{
			return default(bool);
		}

		// Token: 0x060073A2 RID: 29602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073A2")]
		[Address(RVA = "0xBD8E", Offset = "0xBD8E", VA = "0xBD8E")]
		private void SetBlockResetPositions(bool value)
		{
		}

		// Token: 0x060073A3 RID: 29603 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60073A3")]
		public T GetEngine<T>() where T : WorldObjectEngine
		{
			return null;
		}

		// Token: 0x060073A4 RID: 29604 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60073A4")]
		public T GetEngineArgs<T>() where T : WorldObjectEngineArgs
		{
			return null;
		}

		// Token: 0x060073A5 RID: 29605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073A5")]
		[Address(RVA = "0xBD8F", Offset = "0xBD8F", VA = "0xBD8F")]
		public CloudObjectsEngineController()
		{
		}

		// Token: 0x04003C7E RID: 15486
		[Token(Token = "0x4003C7E")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Camera _camera;

		// Token: 0x04003C7F RID: 15487
		[Token(Token = "0x4003C7F")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private CloudsVerticalMovementAnimation _verticalMovementAnimation;

		// Token: 0x04003C80 RID: 15488
		[Token(Token = "0x4003C80")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Canvas _cloudsBgScaler;

		// Token: 0x04003C81 RID: 15489
		[Token(Token = "0x4003C81")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Texture2D _noizeTexture;

		// Token: 0x04003C82 RID: 15490
		[Token(Token = "0x4003C82")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CloudBGParallax _cloudBGParallax;

		// Token: 0x04003C83 RID: 15491
		[Token(Token = "0x4003C83")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _cloudDistance;

		// Token: 0x04003C84 RID: 15492
		[Token(Token = "0x4003C84")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int _chunkSize;

		// Token: 0x04003C85 RID: 15493
		[Token(Token = "0x4003C85")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private List<WorldObjectEngineArgs> _engineArgs;

		// Token: 0x04003C87 RID: 15495
		[Token(Token = "0x4003C87")]
		[FieldOffset(Offset = "0x34")]
		private float _widthCamera;

		// Token: 0x04003C88 RID: 15496
		[Token(Token = "0x4003C88")]
		[FieldOffset(Offset = "0x38")]
		private Vector3 _startCameraPosition;

		// Token: 0x04003C89 RID: 15497
		[Token(Token = "0x4003C89")]
		[FieldOffset(Offset = "0x44")]
		private bool _blockResetPositions;

		// Token: 0x04003C8A RID: 15498
		[Token(Token = "0x4003C8A")]
		[FieldOffset(Offset = "0x48")]
		private readonly List<EngineAndArgs> _enginesAndArgs;

		// Token: 0x04003C8B RID: 15499
		[Token(Token = "0x4003C8B")]
		[FieldOffset(Offset = "0x4C")]
		private WorldMovementResolver _movementResolver;
	}
}
