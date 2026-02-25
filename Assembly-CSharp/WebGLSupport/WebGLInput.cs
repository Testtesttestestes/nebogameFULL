using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AOT;
using Il2CppDummyDll;
using UnityEngine;

namespace WebGLSupport
{
	// Token: 0x02000026 RID: 38
	[Token(Token = "0x2000026")]
	public class WebGLInput : MonoBehaviour, IComparable<WebGLInput>
	{
		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600019F RID: 415 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060001A0 RID: 416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002D")]
		public static string CanvasId
		{
			[Token(Token = "0x600019F")]
			[Address(RVA = "0x5660", Offset = "0x5660", VA = "0x5660")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001A0")]
			[Address(RVA = "0x5661", Offset = "0x5661", VA = "0x5661")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x5663", Offset = "0x5663", VA = "0x5663")]
		private IInputField Setup()
		{
			return null;
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x5664", Offset = "0x5664", VA = "0x5664")]
		private void Awake()
		{
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x5665", Offset = "0x5665", VA = "0x5665")]
		public void OnSelect()
		{
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x5666", Offset = "0x5666", VA = "0x5666")]
		private void OnWindowBlur()
		{
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x000025E0 File Offset: 0x000007E0
		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x5667", Offset = "0x5667", VA = "0x5667")]
		private Rect GetScreenCoordinates(RectTransform uiElement)
		{
			return default(Rect);
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x5668", Offset = "0x5668", VA = "0x5668")]
		internal void DeactivateInputField()
		{
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x5669", Offset = "0x5669", VA = "0x5669")]
		[MonoPInvokeCallback(typeof(Action<int>))]
		private static void OnFocus(int id)
		{
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x4BB6", Offset = "0x4BB6", VA = "0x4BB6")]
		[MonoPInvokeCallback(typeof(Action<int>))]
		private static void OnBlur(int id)
		{
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x566A", Offset = "0x566A", VA = "0x566A")]
		private static IEnumerator Blur(int id)
		{
			return null;
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x4BB7", Offset = "0x4BB7", VA = "0x4BB7")]
		[MonoPInvokeCallback(typeof(Action<int, string>))]
		private static void OnValueChange(int id, string value)
		{
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x4BB8", Offset = "0x4BB8", VA = "0x4BB8")]
		[MonoPInvokeCallback(typeof(Action<int, string>))]
		private static void OnEditEnd(int id, string value)
		{
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x4BB9", Offset = "0x4BB9", VA = "0x4BB9")]
		[MonoPInvokeCallback(typeof(Action<int, int>))]
		private static void OnTab(int id, int value)
		{
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x566B", Offset = "0x566B", VA = "0x566B")]
		private void Update()
		{
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x566C", Offset = "0x566C", VA = "0x566C")]
		private void OnDestroy()
		{
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x566D", Offset = "0x566D", VA = "0x566D")]
		private void OnEnable()
		{
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x566E", Offset = "0x566E", VA = "0x566E")]
		private void OnDisable()
		{
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x000025F8 File Offset: 0x000007F8
		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x566F", Offset = "0x566F", VA = "0x566F", Slot = "4")]
		public int CompareTo(WebGLInput other)
		{
			return 0;
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x5670", Offset = "0x5670", VA = "0x5670")]
		public WebGLInput()
		{
		}

		// Token: 0x040000BE RID: 190
		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<int, WebGLInput> instances;

		// Token: 0x040000C0 RID: 192
		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0x10")]
		internal int id;

		// Token: 0x040000C1 RID: 193
		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x14")]
		private IInputField input;

		// Token: 0x040000C2 RID: 194
		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0x18")]
		private bool blurBlock;

		// Token: 0x040000C3 RID: 195
		[Token(Token = "0x40000C3")]
		[FieldOffset(Offset = "0x19")]
		[Tooltip("show input element on canvas. this will make you select text by drag.")]
		public bool showHtmlElement;

		// Token: 0x02000027 RID: 39
		[Token(Token = "0x2000027")]
		private static class WebGLInputTabFocus
		{
			// Token: 0x060001B4 RID: 436 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60001B4")]
			[Address(RVA = "0x5671", Offset = "0x5671", VA = "0x5671")]
			public static void Add(WebGLInput input)
			{
			}

			// Token: 0x060001B5 RID: 437 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60001B5")]
			[Address(RVA = "0x5672", Offset = "0x5672", VA = "0x5672")]
			public static void Remove(WebGLInput input)
			{
			}

			// Token: 0x060001B6 RID: 438 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60001B6")]
			[Address(RVA = "0x5673", Offset = "0x5673", VA = "0x5673")]
			public static void OnTab(WebGLInput input, int value)
			{
			}

			// Token: 0x040000C4 RID: 196
			[Token(Token = "0x40000C4")]
			[FieldOffset(Offset = "0x0")]
			private static List<WebGLInput> inputs;
		}
	}
}
