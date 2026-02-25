using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.InputSystem.LowLevel;

namespace Test
{
	// Token: 0x02000E48 RID: 3656
	[Token(Token = "0x2000E48")]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(Camera))]
	public class TestCameraController : MonoBehaviour
	{
		// Token: 0x0600599C RID: 22940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600599C")]
		[Address(RVA = "0xA6C8", Offset = "0xA6C8", VA = "0xA6C8")]
		private void Awake()
		{
		}

		// Token: 0x0600599D RID: 22941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600599D")]
		[Address(RVA = "0xA6C9", Offset = "0xA6C9", VA = "0xA6C9")]
		public void Init(RectTransform contentContainer)
		{
		}

		// Token: 0x0600599E RID: 22942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600599E")]
		[Address(RVA = "0xA6CA", Offset = "0xA6CA", VA = "0xA6CA")]
		private void OnEnable()
		{
		}

		// Token: 0x0600599F RID: 22943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600599F")]
		[Address(RVA = "0xA6CB", Offset = "0xA6CB", VA = "0xA6CB")]
		private void OnDisable()
		{
		}

		// Token: 0x060059A0 RID: 22944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059A0")]
		[Address(RVA = "0xA6CC", Offset = "0xA6CC", VA = "0xA6CC")]
		private void Update()
		{
		}

		// Token: 0x060059A1 RID: 22945 RVA: 0x0000FE58 File Offset: 0x0000E058
		[Token(Token = "0x60059A1")]
		[Address(RVA = "0xA6CD", Offset = "0xA6CD", VA = "0xA6CD")]
		private Vector3 TouchToWorld(TouchState touch)
		{
			return default(Vector3);
		}

		// Token: 0x060059A2 RID: 22946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059A2")]
		[Address(RVA = "0xA6CE", Offset = "0xA6CE", VA = "0xA6CE")]
		public TestCameraController()
		{
		}

		// Token: 0x0400305A RID: 12378
		[Token(Token = "0x400305A")]
		[FieldOffset(Offset = "0x10")]
		private bool _isDrag;

		// Token: 0x0400305B RID: 12379
		[Token(Token = "0x400305B")]
		[FieldOffset(Offset = "0x14")]
		private Vector3 _startCameraPosition;

		// Token: 0x0400305C RID: 12380
		[Token(Token = "0x400305C")]
		[FieldOffset(Offset = "0x20")]
		private Vector3 _startMousePosition;

		// Token: 0x0400305D RID: 12381
		[Token(Token = "0x400305D")]
		[FieldOffset(Offset = "0x2C")]
		private Bounds _viewBounds;

		// Token: 0x0400305E RID: 12382
		[Token(Token = "0x400305E")]
		[FieldOffset(Offset = "0x44")]
		private RectTransform _contentContainer;

		// Token: 0x0400305F RID: 12383
		[Token(Token = "0x400305F")]
		[FieldOffset(Offset = "0x48")]
		private readonly Dictionary<Transform, Vector3> _content;

		// Token: 0x04003060 RID: 12384
		[Token(Token = "0x4003060")]
		[FieldOffset(Offset = "0x4C")]
		private Camera _camera;
	}
}
