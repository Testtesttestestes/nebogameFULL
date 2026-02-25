using System;
using System.Collections;
using System.Collections.Generic;
using AOT;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace WebGLSupport
{
	// Token: 0x02000023 RID: 35
	[Token(Token = "0x2000023")]
	public class WebGLInputMobile : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
	{
		// Token: 0x06000181 RID: 385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000181")]
		[Address(RVA = "0x5644", Offset = "0x5644", VA = "0x5644")]
		private void Awake()
		{
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000182")]
		[Address(RVA = "0x5645", Offset = "0x5645", VA = "0x5645", Slot = "4")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000183")]
		[Address(RVA = "0x4BB2", Offset = "0x4BB2", VA = "0x4BB2")]
		[MonoPInvokeCallback(typeof(Action<int>))]
		private static void OnTouchEnd(int id)
		{
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000184")]
		[Address(RVA = "0x5646", Offset = "0x5646", VA = "0x5646")]
		private static IEnumerator RegisterOnFocusOut(int id)
		{
			return null;
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000185")]
		[Address(RVA = "0x4BB3", Offset = "0x4BB3", VA = "0x4BB3")]
		[MonoPInvokeCallback(typeof(Action<int>))]
		private static void OnFocusOut(int id)
		{
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000186")]
		[Address(RVA = "0x5647", Offset = "0x5647", VA = "0x5647")]
		public WebGLInputMobile()
		{
		}

		// Token: 0x040000B9 RID: 185
		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<int, WebGLInputMobile> instances;

		// Token: 0x040000BA RID: 186
		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0x10")]
		private int id;
	}
}
