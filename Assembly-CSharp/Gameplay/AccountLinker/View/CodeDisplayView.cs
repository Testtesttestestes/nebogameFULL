using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using Utils;

namespace Gameplay.AccountLinker.View
{
	// Token: 0x02000DF9 RID: 3577
	[Token(Token = "0x2000DF9")]
	public class CodeDisplayView : MonoBehaviour
	{
		// Token: 0x06005749 RID: 22345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005749")]
		[Address(RVA = "0xA4C4", Offset = "0xA4C4", VA = "0xA4C4")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600574A RID: 22346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600574A")]
		[Address(RVA = "0xA4C5", Offset = "0xA4C5", VA = "0xA4C5")]
		private void Awake()
		{
		}

		// Token: 0x0600574B RID: 22347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600574B")]
		[Address(RVA = "0xA4C6", Offset = "0xA4C6", VA = "0xA4C6")]
		private void HandleClickOnCodeField(PointerEventData obj)
		{
		}

		// Token: 0x170011CD RID: 4557
		// (get) Token: 0x0600574C RID: 22348 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600574D RID: 22349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011CD")]
		public string Code
		{
			[Token(Token = "0x600574C")]
			[Address(RVA = "0xA4C7", Offset = "0xA4C7", VA = "0xA4C7")]
			get
			{
				return null;
			}
			[Token(Token = "0x600574D")]
			[Address(RVA = "0xA4C8", Offset = "0xA4C8", VA = "0xA4C8")]
			set
			{
			}
		}

		// Token: 0x0600574E RID: 22350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600574E")]
		[Address(RVA = "0xA4C9", Offset = "0xA4C9", VA = "0xA4C9")]
		private void HandleCodeChanged()
		{
		}

		// Token: 0x0600574F RID: 22351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600574F")]
		[Address(RVA = "0xA4CA", Offset = "0xA4CA", VA = "0xA4CA")]
		public CodeDisplayView()
		{
		}

		// Token: 0x04002F4B RID: 12107
		[Token(Token = "0x4002F4B")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _codeTextField;

		// Token: 0x04002F4C RID: 12108
		[Token(Token = "0x4002F4C")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private MonoPointerClickHandler _clickHandlerOnCodeField;

		// Token: 0x04002F4D RID: 12109
		[Token(Token = "0x4002F4D")]
		[FieldOffset(Offset = "0x18")]
		private string _code;
	}
}
