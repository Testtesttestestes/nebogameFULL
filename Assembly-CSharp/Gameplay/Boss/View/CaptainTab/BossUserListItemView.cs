using System;
using System.Runtime.CompilerServices;
using AssetContent;
using Core.Data;
using Gameplay.Rating.View;
using Il2CppDummyDll;
using TMPro;
using UI.Elements.Counters;
using UnityEngine;
using UnityEngine.EventSystems;
using Utils;

namespace Gameplay.Boss.View.CaptainTab
{
	// Token: 0x02000B85 RID: 2949
	[Token(Token = "0x2000B85")]
	public class BossUserListItemView : MonoBehaviour
	{
		// Token: 0x140001C7 RID: 455
		// (add) Token: 0x060047AD RID: 18349 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060047AE RID: 18350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001C7")]
		public event Action<UserData> ClickedEvent
		{
			[Token(Token = "0x60047AD")]
			[Address(RVA = "0x9639", Offset = "0x9639", VA = "0x9639")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60047AE")]
			[Address(RVA = "0x963A", Offset = "0x963A", VA = "0x963A")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060047AF RID: 18351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047AF")]
		[Address(RVA = "0x963B", Offset = "0x963B", VA = "0x963B")]
		private void Awake()
		{
		}

		// Token: 0x060047B0 RID: 18352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047B0")]
		[Address(RVA = "0x963C", Offset = "0x963C", VA = "0x963C")]
		private void OnDestroy()
		{
		}

		// Token: 0x060047B1 RID: 18353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047B1")]
		[Address(RVA = "0x963D", Offset = "0x963D", VA = "0x963D")]
		private void ClickHandlerOnOnClickEvent(PointerEventData obj)
		{
		}

		// Token: 0x17000E56 RID: 3670
		// (get) Token: 0x060047B2 RID: 18354 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060047B3 RID: 18355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E56")]
		public UserData UserData
		{
			[Token(Token = "0x60047B2")]
			[Address(RVA = "0x963E", Offset = "0x963E", VA = "0x963E")]
			get
			{
				return null;
			}
			[Token(Token = "0x60047B3")]
			[Address(RVA = "0x963F", Offset = "0x963F", VA = "0x963F")]
			set
			{
			}
		}

		// Token: 0x060047B4 RID: 18356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047B4")]
		[Address(RVA = "0x9640", Offset = "0x9640", VA = "0x9640")]
		public BossUserListItemView()
		{
		}

		// Token: 0x04002763 RID: 10083
		[Token(Token = "0x4002763")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private MonoPointerClickHandler _clickHandler;

		// Token: 0x04002764 RID: 10084
		[Token(Token = "0x4002764")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _label;

		// Token: 0x04002765 RID: 10085
		[Token(Token = "0x4002765")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UserView _userView;

		// Token: 0x04002766 RID: 10086
		[Token(Token = "0x4002766")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private GameRawImage _cultIcon;

		// Token: 0x04002767 RID: 10087
		[Token(Token = "0x4002767")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LevelCounter _levelCounter;

		// Token: 0x04002769 RID: 10089
		[Token(Token = "0x4002769")]
		[FieldOffset(Offset = "0x28")]
		private UserData _userData;
	}
}
