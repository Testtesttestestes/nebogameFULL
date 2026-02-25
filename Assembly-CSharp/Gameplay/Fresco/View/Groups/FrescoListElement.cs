using System;
using Il2CppDummyDll;
using Protocol.Dic;
using Protocol.Fresco;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Fresco.View.Groups
{
	// Token: 0x02000800 RID: 2048
	[Token(Token = "0x2000800")]
	public class FrescoListElement : MonoBehaviour
	{
		// Token: 0x17000967 RID: 2407
		// (get) Token: 0x06003008 RID: 12296 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000967")]
		private string White
		{
			[Token(Token = "0x6003008")]
			[Address(RVA = "0x806E", Offset = "0x806E", VA = "0x806E")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000968 RID: 2408
		// (get) Token: 0x06003009 RID: 12297 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000968")]
		private string Green
		{
			[Token(Token = "0x6003009")]
			[Address(RVA = "0x806F", Offset = "0x806F", VA = "0x806F")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000969 RID: 2409
		// (get) Token: 0x0600300A RID: 12298 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000969")]
		private string Purple
		{
			[Token(Token = "0x600300A")]
			[Address(RVA = "0x8070", Offset = "0x8070", VA = "0x8070")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600300B RID: 12299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600300B")]
		[Address(RVA = "0x8071", Offset = "0x8071", VA = "0x8071")]
		private void Start()
		{
		}

		// Token: 0x0600300C RID: 12300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600300C")]
		[Address(RVA = "0x8072", Offset = "0x8072", VA = "0x8072")]
		private void FrescoClickedHandler()
		{
		}

		// Token: 0x0600300D RID: 12301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600300D")]
		[Address(RVA = "0x8073", Offset = "0x8073", VA = "0x8073")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600300E RID: 12302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600300E")]
		[Address(RVA = "0x1AD7", Offset = "0x1AD7", VA = "0x1AD7")]
		public void Init(Protocol.Fresco.Fresco fresco, Protocol.Dic.Fresco.Types.FrescoDic frescoDic, int i, bool isOwn, Action<ulong> onFrescoClick)
		{
		}

		// Token: 0x0600300F RID: 12303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600300F")]
		[Address(RVA = "0x8074", Offset = "0x8074", VA = "0x8074")]
		public FrescoListElement()
		{
		}

		// Token: 0x04001A49 RID: 6729
		[Token(Token = "0x4001A49")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Button _button;

		// Token: 0x04001A4A RID: 6730
		[Token(Token = "0x4001A4A")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private FrescoFieldMini _field;

		// Token: 0x04001A4B RID: 6731
		[Token(Token = "0x4001A4B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _number;

		// Token: 0x04001A4C RID: 6732
		[Token(Token = "0x4001A4C")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _text;

		// Token: 0x04001A4D RID: 6733
		[Token(Token = "0x4001A4D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LayoutElement _layoutElement;

		// Token: 0x04001A4E RID: 6734
		[Token(Token = "0x4001A4E")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private GameObject _check;

		// Token: 0x04001A4F RID: 6735
		[Token(Token = "0x4001A4F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color _white;

		// Token: 0x04001A50 RID: 6736
		[Token(Token = "0x4001A50")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Color _green;

		// Token: 0x04001A51 RID: 6737
		[Token(Token = "0x4001A51")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _purple;

		// Token: 0x04001A52 RID: 6738
		[Token(Token = "0x4001A52")]
		[FieldOffset(Offset = "0x58")]
		private Action<ulong> _onFrescoClick;
	}
}
