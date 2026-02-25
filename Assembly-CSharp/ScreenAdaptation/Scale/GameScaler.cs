using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScreenAdaptation.Common;
using UnityEngine;

namespace ScreenAdaptation.Scale
{
	// Token: 0x020000B3 RID: 179
	[Token(Token = "0x20000B3")]
	public class GameScaler : MonoBehaviour
	{
		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060006ED RID: 1773 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060006EE RID: 1774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000B6")]
		public static GameScaler Instance
		{
			[Token(Token = "0x60006ED")]
			[Address(RVA = "0x5AEA", Offset = "0x5AEA", VA = "0x5AEA")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60006EE")]
			[Address(RVA = "0x5AEB", Offset = "0x5AEB", VA = "0x5AEB")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x5AEC", Offset = "0x5AEC", VA = "0x5AEC")]
		private void Awake()
		{
		}

		// Token: 0x140000BF RID: 191
		// (add) Token: 0x060006F0 RID: 1776 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060006F1 RID: 1777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000BF")]
		public event Action GameContentScaledEvent
		{
			[Token(Token = "0x60006F0")]
			[Address(RVA = "0x5AED", Offset = "0x5AED", VA = "0x5AED")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60006F1")]
			[Address(RVA = "0x5AEE", Offset = "0x5AEE", VA = "0x5AEE")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x5AEF", Offset = "0x5AEF", VA = "0x5AEF")]
		public void AddCamera(Camera cam)
		{
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x5AF0", Offset = "0x5AF0", VA = "0x5AF0")]
		public void RemoveCamera(Camera cam)
		{
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x5AF1", Offset = "0x5AF1", VA = "0x5AF1")]
		public void AddCanvas(Canvas canvas)
		{
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x5AF2", Offset = "0x5AF2", VA = "0x5AF2")]
		public void RemoveCanvas(Canvas canvas)
		{
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x5AF3", Offset = "0x5AF3", VA = "0x5AF3")]
		private void Start()
		{
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x5AF4", Offset = "0x5AF4", VA = "0x5AF4")]
		private void InstanceOnAppSizeChangedEvent(int w, int h)
		{
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x5AF5", Offset = "0x5AF5", VA = "0x5AF5")]
		private void Update()
		{
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x5AF6", Offset = "0x5AF6", VA = "0x5AF6")]
		private void OnDestroy()
		{
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x5AF7", Offset = "0x5AF7", VA = "0x5AF7")]
		public GameScaler()
		{
		}

		// Token: 0x0400024F RID: 591
		[Token(Token = "0x400024F")]
		[FieldOffset(Offset = "0x14")]
		private AbstractScreenScale _screenScalerImpl;

		// Token: 0x04000250 RID: 592
		[Token(Token = "0x4000250")]
		[FieldOffset(Offset = "0x18")]
		private readonly HashSet<Camera> _cameras;

		// Token: 0x04000251 RID: 593
		[Token(Token = "0x4000251")]
		[FieldOffset(Offset = "0x1C")]
		private readonly HashSet<Canvas> _canvases;

		// Token: 0x04000252 RID: 594
		[Token(Token = "0x4000252")]
		[FieldOffset(Offset = "0x20")]
		private bool _contentChanged;

		// Token: 0x04000253 RID: 595
		[Token(Token = "0x4000253")]
		[FieldOffset(Offset = "0x21")]
		private bool _appSizeChanged;
	}
}
