describe('Final Calidad', () => {
  it('Generar Cartas', () => {
    cy.visit(Cypress.env('base_url'))
    cy.get('#guardardatos').click()
    cy.location('pathname').should('eq','/home/guardardatos')
  })
  it('Entrar al Privacy', () => {
    cy.visit(Cypress.env('base_url'))
    cy.get('#privacy').click()
    cy.location('pathname').should('eq','/Home/Privacy')
  })
})