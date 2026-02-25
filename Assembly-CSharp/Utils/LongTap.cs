using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Utils
{
	// Token: 0x02000043 RID: 67
	[Token(Token = "0x2000043")]
	[DisallowMultipleComponent]
	public class LongTap : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDisposable
	{
		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000264 RID: 612 RVA: 0x00002A00 File Offset: 0x00000C00
		// (set) Token: 0x06000265 RID: 613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000062")]
		public static float TimeOfStartDetect
		{
			[Token(Token = "0x6000264")]
			[Address(RVA = "0x5701", Offset = "0x5701", VA = "0x5701")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000265")]
			[Address(RVA = "0x5702", Offset = "0x5702", VA = "0x5702")]
			set
			{
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000266 RID: 614 RVA: 0x00002A18 File Offset: 0x00000C18
		// (set) Token: 0x06000267 RID: 615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000063")]
		public static float TimeOfDetect
		{
			[Token(Token = "0x6000266")]
			[Address(RVA = "0x5703", Offset = "0x5703", VA = "0x5703")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000267")]
			[Address(RVA = "0x5704", Offset = "0x5704", VA = "0x5704")]
			set
			{
			}
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000268")]
		[Address(RVA = "0x5705", Offset = "0x5705", VA = "0x5705")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000269")]
		[Address(RVA = "0x5706", Offset = "0x5706", VA = "0x5706", Slot = "7")]
		public virtual void Dispose()
		{
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600026A")]
		[Address(RVA = "0x5707", Offset = "0x5707", VA = "0x5707")]
		public void RemoveAllEventHandlers()
		{
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x0600026B RID: 619 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600026C RID: 620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000004")]
		public event LongTap.LongTapHandler StartLongTapEvent
		{
			[Token(Token = "0x600026B")]
			[Address(RVA = "0x5708", Offset = "0x5708", VA = "0x5708")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600026C")]
			[Address(RVA = "0x5709", Offset = "0x5709", VA = "0x5709")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x0600026D RID: 621 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600026E RID: 622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000005")]
		public event LongTap.LongTapHandler FinishLongTapEvent
		{
			[Token(Token = "0x600026D")]
			[Address(RVA = "0x570A", Offset = "0x570A", VA = "0x570A")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600026E")]
			[Address(RVA = "0x570B", Offset = "0x570B", VA = "0x570B")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x0600026F RID: 623 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000270 RID: 624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000006")]
		public event LongTap.LongTapHandler CancelLongTapEvent
		{
			[Token(Token = "0x600026F")]
			[Address(RVA = "0x570C", Offset = "0x570C", VA = "0x570C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000270")]
			[Address(RVA = "0x570D", Offset = "0x570D", VA = "0x570D")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06000271 RID: 625 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000272 RID: 626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000007")]
		public event LongTap.LongTapHandler LongTapEvent
		{
			[Token(Token = "0x6000271")]
			[Address(RVA = "0x570E", Offset = "0x570E", VA = "0x570E")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000272")]
			[Address(RVA = "0x570F", Offset = "0x570F", VA = "0x570F")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000273 RID: 627 RVA: 0x00002A30 File Offset: 0x00000C30
		// (set) Token: 0x06000274 RID: 628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000064")]
		public int CurrentLongTapDetectionCount
		{
			[Token(Token = "0x6000273")]
			[Address(RVA = "0x5710", Offset = "0x5710", VA = "0x5710")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000274")]
			[Address(RVA = "0x5711", Offset = "0x5711", VA = "0x5711")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000275 RID: 629 RVA: 0x00002A48 File Offset: 0x00000C48
		// (set) Token: 0x06000276 RID: 630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000065")]
		public int CurrentStartLongTapDetectionCount
		{
			[Token(Token = "0x6000275")]
			[Address(RVA = "0x5712", Offset = "0x5712", VA = "0x5712")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000276")]
			[Address(RVA = "0x5713", Offset = "0x5713", VA = "0x5713")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000277 RID: 631 RVA: 0x00002A60 File Offset: 0x00000C60
		// (set) Token: 0x06000278 RID: 632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000066")]
		public Vector2 StartTouchPosition
		{
			[Token(Token = "0x6000277")]
			[Address(RVA = "0x5714", Offset = "0x5714", VA = "0x5714")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000278")]
			[Address(RVA = "0x5715", Offset = "0x5715", VA = "0x5715")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000279")]
		[Address(RVA = "0x5716", Offset = "0x5716", VA = "0x5716", Slot = "8")]
		public virtual void OnPointerDown(PointerEventData eventData)
		{
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600027A")]
		[Address(RVA = "0x5717", Offset = "0x5717", VA = "0x5717", Slot = "9")]
		public virtual void OnPointerUp(PointerEventData eventData)
		{
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600027B")]
		[Address(RVA = "0x5718", Offset = "0x5718", VA = "0x5718")]
		private void StopDetectCoroutines()
		{
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600027C")]
		[Address(RVA = "0x5719", Offset = "0x5719", VA = "0x5719")]
		private IEnumerator DetectLongTapCoroutine(float time)
		{
			return null;
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600027D")]
		[Address(RVA = "0x571A", Offset = "0x571A", VA = "0x571A")]
		private IEnumerator DetectStartLongTapCoroutine(float delay)
		{
			return null;
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600027E")]
		[Address(RVA = "0x571B", Offset = "0x571B", VA = "0x571B")]
		public LongTap()
		{
		}

		// Token: 0x04000114 RID: 276
		[Token(Token = "0x4000114")]
		[FieldOffset(Offset = "0x0")]
		private static float _timeOfDetect;

		// Token: 0x04000115 RID: 277
		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0x4")]
		private static float _timeOfStartDetect;

		// Token: 0x0400011D RID: 285
		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0x30")]
		private List<Coroutine> _detectCoroutines;

		// Token: 0x02000044 RID: 68
		// (Invoke) Token: 0x06000281 RID: 641
		[Token(Token = "0x2000044")]
		public delegate void LongTapHandler(LongTap sender);
	}
}
