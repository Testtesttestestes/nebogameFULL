using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.UserInfo.View;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Consts;
using Protocol.Dic;
using UI.ToolTip;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Price
{
	// Token: 0x020001C6 RID: 454
	[Token(Token = "0x20001C6")]
	public class ResourceTable : MonoBehaviour
	{
		// Token: 0x06000C0D RID: 3085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C0D")]
		[Address(RVA = "0x5F20", Offset = "0x5F20", VA = "0x5F20")]
		private void Awake()
		{
		}

		// Token: 0x06000C0E RID: 3086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C0E")]
		[Address(RVA = "0x5F21", Offset = "0x5F21", VA = "0x5F21")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000C0F RID: 3087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C0F")]
		[Address(RVA = "0x5F22", Offset = "0x5F22", VA = "0x5F22")]
		public void Init(Dictionaries dict, ZigguratLevelDic zigguratLevelDic)
		{
		}

		// Token: 0x06000C10 RID: 3088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C10")]
		[Address(RVA = "0x5F23", Offset = "0x5F23", VA = "0x5F23")]
		private void MarkerClickedEventHandler()
		{
		}

		// Token: 0x06000C11 RID: 3089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C11")]
		[Address(RVA = "0x5F24", Offset = "0x5F24", VA = "0x5F24")]
		public void UpdateResources(ResourceSet resources)
		{
		}

		// Token: 0x06000C12 RID: 3090 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000C12")]
		[Address(RVA = "0x5F25", Offset = "0x5F25", VA = "0x5F25")]
		private BaseToolTipData GetTooltipData(Protocol.Consts.Resources resourceId)
		{
			return null;
		}

		// Token: 0x06000C13 RID: 3091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C13")]
		[Address(RVA = "0x5F26", Offset = "0x5F26", VA = "0x5F26")]
		public ResourceTable()
		{
		}

		// Token: 0x06000C14 RID: 3092 RVA: 0x00003DC8 File Offset: 0x00001FC8
		[Token(Token = "0x6000C14")]
		[Address(RVA = "0x5F27", Offset = "0x5F27", VA = "0x5F27")]
		[CompilerGenerated]
		private int <UpdateResources>g__HandleVisibility|15_0(in ResourceTable.ResourceInstance instance, double value, ref ResourceTable.<>c__DisplayClass15_0 A_3)
		{
			return 0;
		}

		// Token: 0x040005A3 RID: 1443
		[Token(Token = "0x40005A3")]
		private const float WARNING_THRESHOLD = 0.75f;

		// Token: 0x040005A4 RID: 1444
		[Token(Token = "0x40005A4")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private bool _hideZeroElements;

		// Token: 0x040005A5 RID: 1445
		[Token(Token = "0x40005A5")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private RectTransform _content;

		// Token: 0x040005A6 RID: 1446
		[Token(Token = "0x40005A6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TreasuryTitleIconValueBackground _rowPrefab;

		// Token: 0x040005A7 RID: 1447
		[Token(Token = "0x40005A7")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Button _marker;

		// Token: 0x040005A8 RID: 1448
		[Token(Token = "0x40005A8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _warningGroup;

		// Token: 0x040005A9 RID: 1449
		[Token(Token = "0x40005A9")]
		[FieldOffset(Offset = "0x24")]
		private bool _isInit;

		// Token: 0x040005AA RID: 1450
		[Token(Token = "0x40005AA")]
		[FieldOffset(Offset = "0x28")]
		private ZigguratLevelDic _levelDic;

		// Token: 0x040005AB RID: 1451
		[Token(Token = "0x40005AB")]
		[FieldOffset(Offset = "0x2C")]
		private readonly List<ResourceTable.ResourceInstance> _instances;

		// Token: 0x040005AC RID: 1452
		[Token(Token = "0x40005AC")]
		[FieldOffset(Offset = "0x30")]
		private Dictionaries _dict;

		// Token: 0x040005AD RID: 1453
		[Token(Token = "0x40005AD")]
		[FieldOffset(Offset = "0x34")]
		private ResourceSet _currentResources;

		// Token: 0x020001C7 RID: 455
		[Token(Token = "0x20001C7")]
		private readonly struct ResourceInstance
		{
			// Token: 0x06000C15 RID: 3093 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000C15")]
			[Address(RVA = "0x5F28", Offset = "0x5F28", VA = "0x5F28")]
			public ResourceInstance(uint resourceId, TreasuryTitleIconValueBackground instance)
			{
			}

			// Token: 0x040005AE RID: 1454
			[Token(Token = "0x40005AE")]
			[FieldOffset(Offset = "0x0")]
			public readonly Protocol.Consts.Resources ResourceId;

			// Token: 0x040005AF RID: 1455
			[Token(Token = "0x40005AF")]
			[FieldOffset(Offset = "0x4")]
			public readonly TreasuryTitleIconValueBackground Instance;
		}
	}
}
