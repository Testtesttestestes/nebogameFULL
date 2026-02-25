using System;
using System.Runtime.CompilerServices;
using AssetContent;
using Gameplay.GdEvents.Model.Categories;
using Gameplay.Inventory.View.Info.InfoBox;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.Elements.Counters;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Gameplay.GdEvents.View.EventsList
{
	// Token: 0x02000734 RID: 1844
	[Token(Token = "0x2000734")]
	public class GdEventItemView : MonoBehaviourWithStates<Category>, IPointerClickHandler, IEventSystemHandler
	{
		// Token: 0x06002C01 RID: 11265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C01")]
		[Address(RVA = "0x7C91", Offset = "0x7C91", VA = "0x7C91")]
		private void OnDestroy()
		{
		}

		// Token: 0x17000860 RID: 2144
		// (get) Token: 0x06002C02 RID: 11266 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002C03 RID: 11267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000860")]
		public Action<CellModel> ClickCallback
		{
			[Token(Token = "0x6002C02")]
			[Address(RVA = "0x7C92", Offset = "0x7C92", VA = "0x7C92")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002C03")]
			[Address(RVA = "0x7C93", Offset = "0x7C93", VA = "0x7C93")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000861 RID: 2145
		// (get) Token: 0x06002C04 RID: 11268 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002C05 RID: 11269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000861")]
		public CellModel Data
		{
			[Token(Token = "0x6002C04")]
			[Address(RVA = "0x7C94", Offset = "0x7C94", VA = "0x7C94")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002C05")]
			[Address(RVA = "0x7C95", Offset = "0x7C95", VA = "0x7C95")]
			set
			{
			}
		}

		// Token: 0x06002C06 RID: 11270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C06")]
		[Address(RVA = "0x7C96", Offset = "0x7C96", VA = "0x7C96")]
		private void HandleDataChanged()
		{
		}

		// Token: 0x06002C07 RID: 11271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C07")]
		[Address(RVA = "0x7C97", Offset = "0x7C97", VA = "0x7C97", Slot = "5")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x06002C08 RID: 11272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C08")]
		[Address(RVA = "0x7C98", Offset = "0x7C98", VA = "0x7C98")]
		public GdEventItemView()
		{
		}

		// Token: 0x04001818 RID: 6168
		[Token(Token = "0x4001818")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI[] _titles;

		// Token: 0x04001819 RID: 6169
		[Token(Token = "0x4001819")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CounterAutoHide _counter;

		// Token: 0x0400181A RID: 6170
		[Token(Token = "0x400181A")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private GameRawImage _backgroundImage;

		// Token: 0x0400181B RID: 6171
		[Token(Token = "0x400181B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private BackTimeView _timer;

		// Token: 0x0400181C RID: 6172
		[Token(Token = "0x400181C")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private LoaderValueRowView _progressRow;

		// Token: 0x0400181E RID: 6174
		[Token(Token = "0x400181E")]
		[FieldOffset(Offset = "0x34")]
		private CellModel _data;
	}
}
