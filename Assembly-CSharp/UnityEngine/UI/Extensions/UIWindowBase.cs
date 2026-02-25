using System;
using Il2CppDummyDll;
using UnityEngine.EventSystems;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x0200001E RID: 30
	[Token(Token = "0x200001E")]
	[RequireComponent(typeof(RectTransform))]
	[AddComponentMenu("UI/Extensions/UI Window Base")]
	public class UIWindowBase : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler
	{
		// Token: 0x06000156 RID: 342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000156")]
		[Address(RVA = "0x561B", Offset = "0x561B", VA = "0x561B")]
		private void Start()
		{
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000157")]
		[Address(RVA = "0x561C", Offset = "0x561C", VA = "0x561C")]
		private void Update()
		{
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000158")]
		[Address(RVA = "0x561D", Offset = "0x561D", VA = "0x561D", Slot = "5")]
		public void OnDrag(PointerEventData eventData)
		{
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000159")]
		[Address(RVA = "0x561E", Offset = "0x561E", VA = "0x561E", Slot = "4")]
		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015A")]
		[Address(RVA = "0x561F", Offset = "0x561F", VA = "0x561F", Slot = "6")]
		public void OnEndDrag(PointerEventData eventData)
		{
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015B")]
		[Address(RVA = "0x5620", Offset = "0x5620", VA = "0x5620")]
		private void resetCoordinatePosition()
		{
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00002490 File Offset: 0x00000690
		[Token(Token = "0x600015C")]
		[Address(RVA = "0x5621", Offset = "0x5621", VA = "0x5621")]
		private Vector3 ScreenToCanvas(Vector3 screenPosition)
		{
			return default(Vector3);
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015D")]
		[Address(RVA = "0x5622", Offset = "0x5622", VA = "0x5622")]
		public UIWindowBase()
		{
		}

		// Token: 0x040000A6 RID: 166
		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x10")]
		private RectTransform m_transform;

		// Token: 0x040000A7 RID: 167
		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x14")]
		private bool _isDragging;

		// Token: 0x040000A8 RID: 168
		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x0")]
		public static bool ResetCoords;

		// Token: 0x040000A9 RID: 169
		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x18")]
		private Vector3 m_originalCoods;

		// Token: 0x040000AA RID: 170
		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x24")]
		private Canvas m_canvas;

		// Token: 0x040000AB RID: 171
		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x28")]
		private RectTransform m_canvasRectTransform;

		// Token: 0x040000AC RID: 172
		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x2C")]
		public int KeepWindowInCanvas;
	}
}
