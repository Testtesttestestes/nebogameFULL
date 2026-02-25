using System;
using Core.Dict;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using Utils;

namespace UI.Wiki
{
	// Token: 0x02000118 RID: 280
	[Token(Token = "0x2000118")]
	public class WikiUriRouter : MonoPointerClickHandler
	{
		// Token: 0x060008CC RID: 2252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008CC")]
		[Address(RVA = "0x5C58", Offset = "0x5C58", VA = "0x5C58")]
		private void Start()
		{
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008CD")]
		[Address(RVA = "0x5C59", Offset = "0x5C59", VA = "0x5C59")]
		public void SetData(Uri uri, params object[] args)
		{
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008CE")]
		[Address(RVA = "0x1B4E", Offset = "0x1B4E", VA = "0x1B4E")]
		public void SetData(IDictProvider dictProvider, params object[] args)
		{
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008CF")]
		[Address(RVA = "0x5C5A", Offset = "0x5C5A", VA = "0x5C5A")]
		private void HandleClickEvent(PointerEventData obj)
		{
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008D0")]
		[Address(RVA = "0x5C5B", Offset = "0x5C5B", VA = "0x5C5B")]
		public void Execute(Uri uri, params object[] args)
		{
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008D1")]
		[Address(RVA = "0x5C5C", Offset = "0x5C5C", VA = "0x5C5C")]
		public WikiUriRouter()
		{
		}

		// Token: 0x04000334 RID: 820
		[Token(Token = "0x4000334")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _relativePathTpl;

		// Token: 0x04000335 RID: 821
		[Token(Token = "0x4000335")]
		[FieldOffset(Offset = "0x24")]
		private Uri _uri;

		// Token: 0x04000336 RID: 822
		[Token(Token = "0x4000336")]
		[FieldOffset(Offset = "0x28")]
		private object[] _args;
	}
}
