using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UI.ToolTip.Controller;
using UnityEngine;
using UnityEngine.EventSystems;
using Utils;

namespace UI.ToolTip
{
	// Token: 0x0200013B RID: 315
	[Token(Token = "0x200013B")]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(LongTap))]
	public class ToolTip : MonoBehaviour, IToolTipSource, IDisposable, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		// Token: 0x1700013E RID: 318
		// (get) Token: 0x0600096D RID: 2413 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600096E RID: 2414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700013E")]
		public IToolTipController ToolTipController
		{
			[Token(Token = "0x600096D")]
			[Address(RVA = "0x5CDC", Offset = "0x5CDC", VA = "0x5CDC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600096E")]
			[Address(RVA = "0x5CDD", Offset = "0x5CDD", VA = "0x5CDD")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x0600096F RID: 2415 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700013F")]
		public LongTap LongTap
		{
			[Token(Token = "0x600096F")]
			[Address(RVA = "0x5CDE", Offset = "0x5CDE", VA = "0x5CDE")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000970")]
		[Address(RVA = "0x5CDF", Offset = "0x5CDF", VA = "0x5CDF", Slot = "9")]
		public virtual void Dispose()
		{
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000971")]
		[Address(RVA = "0x5CE0", Offset = "0x5CE0", VA = "0x5CE0", Slot = "7")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000972")]
		[Address(RVA = "0x5CE1", Offset = "0x5CE1", VA = "0x5CE1", Slot = "8")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000973")]
		[Address(RVA = "0x5CE2", Offset = "0x5CE2", VA = "0x5CE2")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000974")]
		[Address(RVA = "0x5CE3", Offset = "0x5CE3", VA = "0x5CE3")]
		private void OnDisable()
		{
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000975")]
		[Address(RVA = "0x5CE4", Offset = "0x5CE4", VA = "0x5CE4")]
		private void Awake()
		{
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000976")]
		[Address(RVA = "0x5CE5", Offset = "0x5CE5", VA = "0x5CE5")]
		private void Start()
		{
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000977")]
		[Address(RVA = "0x5CE6", Offset = "0x5CE6", VA = "0x5CE6")]
		private void HandleStartLongTapEvent(LongTap sender)
		{
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000978")]
		[Address(RVA = "0x5CE7", Offset = "0x5CE7", VA = "0x5CE7")]
		private void HandleCancelLongTapEvent(LongTap sender)
		{
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000979")]
		[Address(RVA = "0x5CE8", Offset = "0x5CE8", VA = "0x5CE8")]
		private void HandleLongTapEvent(LongTap sender)
		{
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600097A")]
		[Address(RVA = "0x5CE9", Offset = "0x5CE9", VA = "0x5CE9")]
		private void HandleShow()
		{
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600097B")]
		[Address(RVA = "0x5CEA", Offset = "0x5CEA", VA = "0x5CEA")]
		private void HandleHide()
		{
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x0600097C RID: 2428 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000140")]
		public IToolTipDataProvider ToolTipDataProvider
		{
			[Token(Token = "0x600097C")]
			[Address(RVA = "0x5CEB", Offset = "0x5CEB", VA = "0x5CEB", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600097D")]
		[Address(RVA = "0x5CEC", Offset = "0x5CEC", VA = "0x5CEC", Slot = "5")]
		public void GetStartPosition(out Vector3 position)
		{
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x0600097E RID: 2430 RVA: 0x00003798 File Offset: 0x00001998
		// (set) Token: 0x0600097F RID: 2431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000141")]
		public new bool enabled
		{
			[Token(Token = "0x600097E")]
			[Address(RVA = "0x5CED", Offset = "0x5CED", VA = "0x5CED")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600097F")]
			[Address(RVA = "0x5CEE", Offset = "0x5CEE", VA = "0x5CEE")]
			set
			{
			}
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000980")]
		[Address(RVA = "0x5CEF", Offset = "0x5CEF", VA = "0x5CEF")]
		public ToolTip()
		{
		}

		// Token: 0x0400038A RID: 906
		[Token(Token = "0x400038A")]
		[FieldOffset(Offset = "0x14")]
		private LongTap _longTap;
	}
}
